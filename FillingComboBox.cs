public class country
{
  public string country_name { get; set; }
  public int country_id { get; set; }
}


List<country> listCountry = new List<country>();

listCountry.Add(new country { country_name = "United States", country_id = 1 });
listCountry.Add(new country { country_name = "Philippines", country_id = 2 });
listCountry.Add(new country { country_name = "United Kingdom", country_id = 3 });

this.fixedComboBoxCountry.DisplayMember = "country_name";                        
this.fixedComboBoxCountry.ValueMember = "country_id";
this.fixedComboBoxCountry.DataSource = listCountry;
this.fixedComboBoxCountry.DataBindings.Add("SelectedValue", personBindingSource, "country_id");
