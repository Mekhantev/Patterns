﻿namespace Core.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            return _instance ?? (_instance = new Singleton());
        }
    }
}