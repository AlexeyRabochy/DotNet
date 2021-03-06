﻿using System;
using System.Collections.Generic;

namespace RegExp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var emailValidator = new EmailValidator();
            var phoneValidator = new PhoneValidator();
            var postIndexPalidator = new PostIndexValidator();

            while (true)
            {
                Console.WriteLine("Введите строку для проверки");
                var stringToCheck = Console.ReadLine();
                if (stringToCheck == String.Empty)
                {
                    return;
                }

                emailValidator.CheckValidity(stringToCheck);
                phoneValidator.CheckValidity(stringToCheck);
                postIndexPalidator.CheckValidity(stringToCheck);
            }

        }
    }
}