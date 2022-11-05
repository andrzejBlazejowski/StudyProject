
using StudyProject.Model;
using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace Firma.ViewModels
{
    public class AddSizeTypeViewModel : AddViewModel<size_type>
    {
        public AddSizeTypeViewModel()
            : base("rozmiar")
        {
            Item = new size_type();
        }
        public int Id {
            get 
            {
                return Item.id;
            }
            set 
            {
                if (value != Item.id) { 
                    Item.id = value;
                    base.OnPropertyChanged(nameof(Item.id));
                }
            }
        }
        public string Name
        {
            get
            {
                return Item.name;
            }
            set
            {
                if (value != Item.name)
                {
                    Item.name = value;
                    base.OnPropertyChanged(nameof(Item.name));
                }
            }
        }
        public decimal MaxHeight
        {
            get
            {
                return Item.max_height;
            }
            set
            {
                if (value != Item.max_height)
                {
                    Item.max_height = value;
                    base.OnPropertyChanged(nameof(Item.max_height));
                }
            }
        }
        public decimal MaxWidth
        {
            get
            {
                return Item.max_width;
            }
            set
            {
                if (value != Item.max_width)
                {
                    Item.max_width = value;
                    base.OnPropertyChanged(nameof(Item.max_width));
                }
            }
        }
        public Boolean IsActive
        {
            get
            {
                return Item.is_active;
            }
            set
            {
                if (value != Item.is_active)
                {
                    Item.is_active = value;
                    base.OnPropertyChanged(nameof(Item.is_active));
                }
            }
        }
        public DateTime CreateDate
        {
            get
            {
                return Item.create_date;
            }
            set
            {
                if (value != Item.create_date)
                {
                    Item.create_date = value;
                    base.OnPropertyChanged(nameof(Item.create_date));
                }
            }
        }

        public override void Save()
        {
            Item.is_active = true;
            DB.size_type.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
