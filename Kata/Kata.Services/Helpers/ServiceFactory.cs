using System;

namespace Kata.Services.Helpers
{
    public class ServiceFactory
    {
        public static GildedRoseService CreateGildedRoseService()
        {
            return new GildedRoseService();
        }
    }
}
