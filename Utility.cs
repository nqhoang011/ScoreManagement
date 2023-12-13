using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;
using ScoreManagement.Models;

namespace ScoreManagement
{
    internal static class Utility
    {
        public static Account account = new Account();
        static public string ImagePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\IMG\";
        static public bool IsOpeningForm(string formname)
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name == formname)
                    return true;
            return false;
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
