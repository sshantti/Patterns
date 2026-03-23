using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Proxy
{
    public enum Role
    {
        Student,
        Admin
    }

    public interface ILibraryAdmin 
    { 
        void DeleteBook(string title); 
    }

    public class RealLibraryAdmin : ILibraryAdmin
    {
        public void DeleteBook(string title) => Console.WriteLine($"RealAdmin: Книга '{title}' удалена из каталога.");
    }

    internal class AdminProxy : ILibraryAdmin
    {
        private RealLibraryAdmin? _realAdmin;
        private Role _userRole;

        public AdminProxy(Role role)
        {
            _userRole = role;
        }

        public void DeleteBook(string title)
        {
            if (CheckAccess())
            {
                _realAdmin = new RealLibraryAdmin();
                _realAdmin.DeleteBook(title);
            }
            else
            {
                Console.WriteLine("Proxy: Ошибка доступа. Требуются права администратора.");
            }
        }

        private bool CheckAccess() => _userRole == Role.Admin;
    }
}