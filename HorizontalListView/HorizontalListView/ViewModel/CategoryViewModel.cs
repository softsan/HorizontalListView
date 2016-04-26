using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace HorizontalListView
{
	public class CategoryViewModel : BaseViewModel
	{
		private ObservableCollection<Categories> _categories = new ObservableCollection<Categories> ();

		public ObservableCollection<Categories> Categories {
			get{ return _categories; }
			set {
				value = _categories;
				ChangeAndNotify (ref this._categories, value, "Categories");
			}
		}

		private Command _selectedItemCommand;

		public Command SelectedItemCommand {
			get {
				return _selectedItemCommand ?? (_selectedItemCommand = new Command (async () => {
					//TODO: Selected item
				}));
			}
		}

		public CategoryViewModel ()
		{
			this.BindData ();
		}

		private void BindData ()
		{
			Categories = new ObservableCollection<Categories> ();
			Categories.Add (new Categories () { 
				Id = 1,
				Name = "Cat1",
				CategoryItem = GetCatItem (1)
			});

			Categories.Add (new Categories () { 
				Id = 2,
				Name = "Cat2",
				CategoryItem = GetCatItem (2)
			});

			Categories.Add (new Categories () { 
				Id = 3,
				Name = "Cat3",
				CategoryItem = GetCatItem (3)
			});


		}

		private List<CategoryItems> GetCatItem (int catId)
		{
			var item = new List<CategoryItems> () {
				new CategoryItems () {
					Id = 1,
					ItemName = "Item1",
					CatId = 1,
					ImageUrl = "http://www.adiumxtras.com/images/pictures/stock_person_check_on_x_off_1_18109_6055_image_8917.png"
				},
				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1,
					ImageUrl = "http://www.adiumxtras.com/images/pictures/stock_person_check_on_x_off_1_18109_6055_image_8917.png"
				},
				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1,
					ImageUrl = "http://www.adiumxtras.com/images/pictures/stock_person_check_on_x_off_1_18109_6055_image_8917.png"
				},
				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1,
					ImageUrl = "http://www.adiumxtras.com/images/pictures/stock_person_check_on_x_off_1_18109_6055_image_8917.png"
				},
				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1,
					ImageUrl = "http://www.myfirmsapp.co.uk/wp-content/uploads/2014/02/icon-person-circle2-320x320.png"
				},
				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1,
					ImageUrl = "http://www.myfirmsapp.co.uk/wp-content/uploads/2014/02/icon-person-circle2-320x320.png"
				},
				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1
				},
				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1,
					ImageUrl = "http://www.myfirmsapp.co.uk/wp-content/uploads/2014/02/icon-person-circle2-320x320.png"
				},
				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1
				},
				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1,
					ImageUrl = "http://www.adiumxtras.com/images/pictures/stock_person_check_on_x_off_1_18109_6055_image_8917.png"
				},
				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1
				},
				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1
				},
				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1
				},
				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1
				},

				new CategoryItems () {
					Id = 2,
					ItemName = "Item2",
					CatId = 1
				},

				new CategoryItems () {
					Id = 3,
					ItemName = "Item4",
					CatId = 2,
					ImageUrl = "http://www.adweek.com/fishbowlny/files/original/ariaggna.png"
				},
				new CategoryItems () {
					Id = 4,
					ItemName = "Item5",
					CatId = 2,
					ImageUrl = "http://i.telegraph.co.uk/multimedia/archive/02427/KimJong-un_2427121b.jpg"
				},
				new CategoryItems () {
					Id = 5,
					ItemName = "Item999",
					CatId = 3
				},
			};

			return item.Where (i => i.CatId == catId).ToList ();
			;
		}
	}
}

