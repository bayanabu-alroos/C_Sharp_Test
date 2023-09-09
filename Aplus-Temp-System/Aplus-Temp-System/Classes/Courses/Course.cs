using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplus_Temp_System.Classes.Courses
{
    public sealed class Course
    {
        private Course() { }
        public Course(string pannerImage, string image, short numberOfHours, short duration, float price, string description, string name, List<Level> levels, List<Topic> topics, List<Goals> goals)
        {
            PannerImage = pannerImage;
            Image = image;
            NumberOfHours = numberOfHours;
            this.duration = duration;
            Price = price;
            Description = description;
            Name = name;
            Levels = levels;
            Topics = topics;
            Goals = goals;
        }

        public string PannerImage{ get; set; }
        public string Image{ get; set; }
        public short NumberOfHours{ get; set; }
        public short duration{ get; set; }
        public float Price{ get; set; }
        public string Description{ get; set; }
        public string Name{ get; set; }
        public List<Level> Levels { get; set; }
         
        public List<Topic> Topics { get; set; }
         
        public List<Goals> Goals { get; set; }

        ~ Course() { }
    }
}
