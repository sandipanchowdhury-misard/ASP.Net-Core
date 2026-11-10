using System;

namespace SolidPrinciples.WithSRP{

    class ResturantServices
    {
        public void HandleResturantTasks()
        {
            CookMeals();
            ManagingAccounts();
            CleaningTables();
            TakeOrders();
            ServeFoods();
        }

    
    }

    class Chef
        {
            private void CookMeals()
            {
                Console.WriteLine("Cooking Meals....");
            }
        }

    class Accounting
    {
        private void ManagingAccounts()
        {
            Console.WriteLine("Managing Accounts....");
        }
        
    }

    class Cleaner
    {
        private void CleaningTables()
        {
            Console.WriteLine("Cleaning Tables ....");
        }
        
    }

    class Waiter
    {   private void TakeOrders()
        {
            Console.WriteLine("Taking Orders....");
        }

        private void ServeFoods()
        {
            Console.WriteLine("Serving Foods....");
        }
        
    }
}

