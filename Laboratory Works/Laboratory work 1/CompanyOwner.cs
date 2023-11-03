using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Sem3_Lab2_ABOBA
{
    delegate void WorkingDelegate();
    internal class CompanyOwner
    {
        public event WorkingDelegate WorkingEvent;
        public string Name { get; set; }
        
        public void StartWorking()
        {
            try
            {
                this.WorkingEvent();
            }
            catch(CustomException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Негайно вирішіть проблему з перевтомою працівників!");
            }
        }
    }
}
