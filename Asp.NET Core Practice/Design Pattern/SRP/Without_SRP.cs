using System;

namespace SolidPrinciples.WithoutSRP{

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

    private void CookMeals()
    {
        Console.WriteLine("Cooking Meals....");
    }
    
    private void ManagingAccounts()
    {
        Console.WriteLine("Managing Accounts....");
    }

        private void CleaningTables()
    {
        Console.WriteLine("Cleaning Tables ....");
    }

        private void TakeOrders()
    {
        Console.WriteLine("Taking Orders....");
    }

        private void ServeFoods()
    {
        Console.WriteLine("Serving Foods....");
    }
    
}
}