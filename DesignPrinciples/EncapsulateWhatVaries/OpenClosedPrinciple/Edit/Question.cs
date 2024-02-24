namespace OpenClosedPrinciple.Edit
{
    abstract  class Question
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public int Mark { get; set; }
       public abstract void Print();
    }

}

