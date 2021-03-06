﻿namespace Core.Observer
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void Remove(IObserver observer);
        void NotifyObservers();
    }
}