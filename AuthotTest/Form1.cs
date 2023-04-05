using Market.DataAccess.Contexts;
using Market.Entity.Classes.EFTest;

namespace AuthotTest
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      using (var context = new LocalDbContextEf())
      {
        context.Database.EnsureCreated();
        var authors = new List<Arkadas>
        {
            new Arkadas { FirstName="Carson", LastName="Alexander", BirthDate = DateTime.Parse("1985-09-01")},
            new Arkadas { FirstName="Meredith", LastName="Alonso", BirthDate = DateTime.Parse("1970-09-01")},
            new Arkadas { FirstName="Arturo", LastName="Anand", BirthDate = DateTime.Parse("1963-09-01")},
            new Arkadas { FirstName="Gytis", LastName="Barzdukas", BirthDate = DateTime.Parse("1988-09-01")},
            new Arkadas { FirstName="Yan", LastName="Li", BirthDate = DateTime.Parse("2000-09-01")},
        };

        context.Authors.AddRange(authors);
        context.SaveChanges();

        dataGridView1.DataSource = authors;
      }
    }
  }
}