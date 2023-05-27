using Microsoft.Identity.Client;
using PRN211;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public class Utils
{
	public static bool checkRegex(string txtInput)
	{
        string pattern = @"^ACCT\d{4}$";

        Regex regex = new Regex(pattern);
        Match match = regex.Match(txtInput);

        return match.Success;
    }
	public static student upStudent(string txtName, int txtAge)
	{
		int age = -1;
		age = txtAge;
		if (age <= 0 || string.IsNullOrEmpty(txtName))
		{
			return null;
		}
		else
		{
            var student = new student(txtName, age);
			return student;
        }
	}

	public static string getString(string txtText)
	{
		string result = null;
		if (!string.IsNullOrEmpty(txtText))
		{
            result = txtText;
		}
		else
		{
            result = null;
		}
		return result;
	}
	public static int getAge(int txtAge)
	{
		int age = -1;
		if (txtAge > 0)
		{
			age = txtAge;
		}
		else
		{
			age = -1;
		}
		return age;
	}

    public static string IsValidPhoneNumber(string phoneNumber)
    {
        if (string.IsNullOrEmpty(phoneNumber))
            return null;
		string digitsOnly = Regex.Replace(phoneNumber, @"[^\d]", "");
        if (digitsOnly.Length != phoneNumber.Length)
            return null;
        int length = digitsOnly.Length;
        if (length >= 10 && length <= 11) 
		{
			return digitsOnly;
		}
		else
		{
			return null;
		}
    }

    public static string IsValidEmail(string email)
    {
        if (string.IsNullOrEmpty(email))
            return null;
        // Use the built-in email address validation from .NET
        var address = new System.Net.Mail.MailAddress(email);
		if (address.Address == email)
        {
			// Split the email address by the "@" symbol
			string[] parts = email.Split('@');

			// Check if the part before the "@" symbol contains only letters and digits
			bool isValid = Regex.IsMatch(parts[0], @"^[a-zA-Z0-9]+$");
			if (isValid)
			{
				return email;
			}
			else
			{
				return null;
			}
		}
		else
		{
			return null;
		}
    }
}
