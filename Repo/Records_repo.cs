using UserStorieProject_School_prog.Records;

namespace UserStorieProject_School_prog.Repo
{
    public class Records_repo
    {
        public List<Record_class> Records { get; set; }


        public Records_repo()
        {
            Records = new List<Record_class>() 
            { new Record_class() { Title = "man", Artist = "him", Duration = 200, Id = 1, PublicationYear = 2002 } };
        }

<<<<<<< HEAD
        public List<Record_class> Get() => new List<Record_class>(Records);
=======
        public List<Record_class> Get()
        {
            return Records;
        }
>>>>>>> ef4194d0afc74a8002ef40159f8882899b358064
     }
}
