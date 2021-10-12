namespace BlazorAssignment.Models
{
    public class Adult : Person
    {
        public Job JobTitle { get; set; }

     
        public string GetEyeColor()
        {
            return EyeColor;
    }

       
    }
}