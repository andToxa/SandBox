# Generated by Django 4.2.13 on 2024-05-19 15:04

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('store', '0006_alter_profile_flatnumb'),
    ]

    operations = [
        migrations.AddField(
            model_name='profile',
            name='housenum',
            field=models.CharField(max_length=150, null=True),
        ),
    ]