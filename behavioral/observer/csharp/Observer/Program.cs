using System;
using System.Collections.Generic;

namespace Observer
{
    class JobPost
    {
        protected string title;
        public JobPost(string title)
        {
            this.title= title;
        }
        public string GetTitle()
        {
            return this.title;
        }
    }

    class JobSeeker : IObserver<JobPost>
    {
        protected string name;

        public JobSeeker(string name)
        {
            this.name = name;
        }
        public void OnCompleted()
        {
            Console.WriteLine("New job has been posted to {0}", this.name);
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error {0} !", this.name);
        }

        public void OnNext(JobPost value)
        {
            Console.WriteLine("Hi {0} ! New job posted: {1}", this.name, value.GetTitle());
        }
    }

    class JobPostings : IObservable<JobPost>
    {
        protected List<IObserver<JobPost>> observers;
        public JobPostings()
        {
            observers = new List<IObserver<JobPost>>();
        }
        public IDisposable Subscribe(IObserver<JobPost> observer)
        {
            if(!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<JobPost>> _observers;
            private IObserver<JobPost> _observer;
            public Unsubscriber(List<IObserver<JobPost>> observers, IObserver<JobPost> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if(_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void AddJob(JobPost jobPosting)
        {
            foreach(var observer in observers)
            {
                if(jobPosting == null)
                    observer.OnError(new Exception());
                else
                    observer.OnNext(jobPosting);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create Subscribe
            JobSeeker johnDoe = new JobSeeker("Jone Doe");
            JobSeeker janeDoe = new JobSeeker("Jane Doe");
            // Create publisher and add Subscribe
            JobPostings jobPostings = new JobPostings();
            jobPostings.Subscribe(johnDoe);
            jobPostings.Subscribe(janeDoe);
            // Add a new job and see if subscribe get notified
            jobPostings.AddJob(new JobPost("Software Engineer"));
        }
    }
}
