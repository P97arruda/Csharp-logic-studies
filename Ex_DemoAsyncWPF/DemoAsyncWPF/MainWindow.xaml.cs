using Microsoft.Data.SqlClient;
using System.Windows;

namespace DemoAsyncWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void executaSync_Click(object sender, RoutedEventArgs e)
        {
            List<Rate> Rates = new List<Rate>();

            Rates = CarregaDados();

            ListDados.ItemsSource = Rates;
        }

        private List<Rate> CarregaDados()
        {
            SqlConnection connecation = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Cambios;Integrated Security=True;TrustServerCertificate=True");

            string sql = @"select RateId,Code,TaxRate,Name from Rates";

            List<Rate> Rates = new List<Rate>();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, connecation);

                connecation.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Rates.Add(new Rate
                    {
                        RateId = Convert.ToInt32(reader.GetValue(0)),
                        Code = reader.GetValue(1).ToString(),
                        TaxRate = (float)reader.GetValue(2),
                        Name = reader.GetValue(3).ToString()


                    });
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message} {ex.StackTrace}", "Detalhe da Excepção");
            }

            finally
            {
                connecation.Close();
            }

            return Rates;
        }

        private async void executaAsync_Click(object sender, RoutedEventArgs e)
        {
            List<Rate> Rates = new List<Rate>();

            Rates = await CarregaDadosAsync();

            ListDados.ItemsSource = Rates;
        }


        private async Task<List<Rate>> CarregaDadosAsync()
        {
            SqlConnection connecation = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Cambios;Integrated Security=True;TrustServerCertificate=True");

            string sql = @"select RateId,Code,TaxRate,Name from Rates";

            List<Rate> Rates = new List<Rate>();



            try
            {
                SqlCommand cmd = new SqlCommand(sql, connecation);

                await connecation.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        Rates.Add(new Rate
                        {
                            RateId = Convert.ToInt32(await reader.GetFieldValueAsync<int>(0)),
                            Code = await reader.GetFieldValueAsync<string>(1),
                            TaxRate = await reader.GetFieldValueAsync<float>(2),
                            Name = await reader.GetFieldValueAsync<string>(3)

                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.StackTrace}", "Detalhe da Excepção");
            }

            finally
            {
                connecation.Close();
            }

            return Rates;
        }

        private void LimpaDados_Click(object sender, RoutedEventArgs e)
        {
            ListDados.ItemsSource = null;
        }
    }
}