# Generated by Django 4.2.13 on 2024-05-19 15:07

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('store', '0007_profile_housenum'),
    ]

    operations = [
        migrations.AddField(
            model_name='order',
            name='housenum',
            field=models.CharField(max_length=150, null=True),
        ),
    ]
