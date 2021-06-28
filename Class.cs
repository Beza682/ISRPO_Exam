using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ISRPO
{
    public class Class
    {
        public bool Add(int r, int p)
        {
            DatabaseEntities db = new DatabaseEntities();
            try
            {
                Booking booking  = new Booking();

                if (string.IsNullOrWhiteSpace(r.ToString()) || string.IsNullOrWhiteSpace(p.ToString()))
                {
                    MessageBox.Show("Вы не полностью заполнили форму", "Бронирование", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                else
                {
                    booking.Row_Id = r;
                    booking.Plice_Id = p;
                    booking.Status_Id = 2;
                    db.Booking.Add(booking);
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Внесите корректные значения", "Бронирование", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
    }
}
