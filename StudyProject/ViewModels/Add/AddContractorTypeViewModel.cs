
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
    public class AddContractorTypeViewModel : AddViewModel<contractor_type>
    {
        public AddContractorTypeViewModel()
            : base("producent")
        {
            Item = new contractor_type();
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
        public string Description
        {
            get
            {
                return Item.description;
            }
            set
            {
                if (value != Item.description)
                {
                    Item.description = value;
                    base.OnPropertyChanged(nameof(Item.description));
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
            DB.contractor_type.AddObject(Item);
            DB.SaveChanges();

        }
    }
}
