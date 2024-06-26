from django.shortcuts import redirect, render
from django.contrib.auth import authenticate, login, logout
from django.contrib import messages

from store.forms import CustomUserForm

def register(request):
    form = CustomUserForm()
    if request.method == 'POST':
        form = CustomUserForm(request.POST)
        if form.is_valid():
            form.save()
            messages.success(request, 'Успешная регистрация! Войдите, чтобы зайти продолжить.')
            return redirect('/login')
    context = {'form':form}
    return render(request, "store/auth/register.html", context)

def loginpage(request):

    if request.user.is_authenticated:
        messages.warning(request, "Вы уже в системе.")
        return redirect('/')
    else:
        if request.method == 'POST':
            name = request.POST.get('username')
            passwd = request.POST.get('password')

            user = authenticate(request, username=name, password=passwd)

            if user is not None:
                login(request, user)
                messages.success(request, "Успешно вошли в систему!")
                if user.is_superuser:
                    return redirect('/admin')
                else:
                    return redirect('/')
            else:
                messages.error(request, "Неверное имя пользователя или пароль")
                return redirect("/login")
        return render(request, "store/auth/login.html")
    
def logoutpage(request):
    if request.user.is_authenticated:
        logout(request)
        messages.success(request, "Успешно вышли из системы!")
        return redirect('/')
    else: redirect('/')