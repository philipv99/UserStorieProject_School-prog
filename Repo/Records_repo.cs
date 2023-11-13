using UserStorieProject_School_prog.Records;

namespace UserStorieProject_School_prog.Repo
{
    public class Records_repo
    {
        public List<Record_class> Records { get; set; }


        public Records_repo()
        {
            Records = new List<Record_class>() {
            new Record_class() { Title = "man", Artist = "him", Duration = 200, Id = 1, PublicationYear = 2002 },
            new Record_class() { Title = "woman", Artist = "her", Duration = 400, Id = 2, PublicationYear = 2003 }};
        }


        public List<Record_class> Get()
        {
            return Records;
        }
     }
}
