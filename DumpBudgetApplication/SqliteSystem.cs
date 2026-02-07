using System.Data.SQLite;

namespace DumpBudgetApplication
{
    internal class SqliteSystem
    {
        static public void CreateDatabase()
        {
            SQLiteConnection.CreateFile("DBADataBase.sqlite");

            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=DBADataBase.sqlite;Version=3;"))
            {
                m_dbConnection.Open();

                string SqlTable = "create table tblexpenses (Category int not null, Price real not null , Description TEXT)";
                SQLiteCommand command = new SQLiteCommand(SqlTable, m_dbConnection);
                command.ExecuteNonQuery();

                string SqlTable2 = "create table categorylist (Category int not null ,Name TEXT not null, Description TEXT)";
                SQLiteCommand command2 = new SQLiteCommand(SqlTable2, m_dbConnection);
                command2.ExecuteNonQuery();

                m_dbConnection.Close();

                CreateCategoryData();
                CreateRandomData();
            }
        }

        static void CreateRandomData() /* Dump Data */
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=DBADataBase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql;

            // Category 1 - Food & Kitchen
            sql = @"insert into tblexpenses (Category, Price, Description) values (1, 1200, 'Monthly office kitchen grocery shopping (Coffee, Tea, Snacks)')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (1, 850, 'Staff lunch catering service')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (1, 450, 'Client meeting breakfast expense')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (1, 230, 'Bulk water order for office')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Category 2 - Transportation
            sql = @"insert into tblexpenses (Category, Price, Description) values (2, 1200, 'Company vehicle fuel cost')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (2, 600, 'Taxi expenses for client visits')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (2, 180, 'Monthly parking subscription')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (2, 400, 'Vehicle maintenance and wash')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Category 3 - Rent
            sql = @"insert into tblexpenses (Category, Price, Description) values (3, 8500, 'Main office monthly rent payment')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (3, 600, 'Virtual office address service fee')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (3, 300, 'Building aidat (maintenance) contribution')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Category 4 - Utilities
            sql = @"insert into tblexpenses (Category, Price, Description) values (4, 450, 'Office electricity bill')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (4, 180, 'Water utility bill')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (4, 320, 'Natural gas heating bill')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (4, 250, 'Fiber internet service provider fee')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (4, 190, 'Corporate mobile line bill')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Category 5 - Tax & Legal
            sql = @"insert into tblexpenses (Category, Price, Description) values (5, 3500, 'Quarterly Income Tax Payment')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (5, 1200, 'Monthly VAT payment')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (5, 180, 'Stamp duty expenses')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (5, 1500, 'Accounting service monthly fee')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (5, 450, 'Chamber of Commerce annual dues')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Category 6 - Office Supplies
            sql = @"insert into tblexpenses (Category, Price, Description) values (6, 350, 'Printer paper and toner cartridges')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (6, 150, 'Desk organizers and stationery')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (6, 200, 'Cleaning supplies for office')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Category 7 - Software & Tech
            sql = @"insert into tblexpenses (Category, Price, Description) values (7, 299, 'Annual software subscription license fee')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (7, 99, 'Cloud storage monthly subscription (AWS/Azure)')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (7, 180, 'Project management tool license')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (7, 210, 'Business email service annual fee')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Category 8 - Hardware
            sql = @"insert into tblexpenses (Category, Price, Description) values (8, 4500, 'New laptop monitor for design team')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (8, 650, 'Mechanical keyboard and mouse set')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (8, 300, 'HDMI cables and power strips')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Category 9 - Marketing
            sql = @"insert into tblexpenses (Category, Price, Description) values (9, 1500, 'Google Ads campaign budget')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (9, 600, 'Social media sponsored posts')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (9, 280, 'Freelance graphic design service')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (9, 350, 'Email marketing platform fee')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Category 10 - Insurance
            sql = @"insert into tblexpenses (Category, Price, Description) values (10, 980, 'Office workspace insurance')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (10, 750, 'Company vehicle insurance renewal')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (10, 1200, 'Employee private health insurance')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Category 11 - Education
            sql = @"insert into tblexpenses (Category, Price, Description) values (11, 780, 'Staff professional training course')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (11, 320, 'Technical books and e-books')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (11, 180, 'Online certification exam fee')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Category 12 - Travel
            sql = @"insert into tblexpenses (Category, Price, Description) values (12, 3200, 'Hotel accommodation for business conference')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (12, 850, 'Domestic flight ticket for client meeting')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (12, 420, 'Car rental during business trip')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Category 13 - Other
            sql = @"insert into tblexpenses (Category, Price, Description) values (13, 200, 'Miscellaneous expenses')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (13, 120, 'Unexpected repair cost')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description) values (13, 340, 'Petty cash replenishment')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            m_dbConnection.Close();
        }

        static void CreateCategoryData() /* Dump Data */
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=DBADataBase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql;

            sql = @"insert into categorylist (Category, Name, Description) values (1, 'Food & Kitchen', 'Office kitchen supplies, catering, and business meals')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (2, 'Transportation', 'Fuel, public transport, taxi, and vehicle maintenance')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (3, 'Rent', 'Office rent, virtual office fees, and building maintenance')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (4, 'Utilities', 'Electricity, water, gas, internet, and phone bills')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (5, 'Tax & Legal', 'Taxes, accounting fees, notary, and government charges')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (6, 'Office Supplies', 'Stationery, cleaning supplies, and office consumables')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (7, 'Software', 'Software licenses, subscriptions, and cloud services')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (8, 'Hardware', 'Computers, peripherals, and technical equipment purchases')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (9, 'Marketing', 'Advertising, social media, and promotion expenses')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (10, 'Insurance', 'Workplace, health, and vehicle insurance policies')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (11, 'Education', 'Training courses, seminars, and educational materials')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (12, 'Travel', 'Business travel accommodation and transport tickets')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (13, 'Other', 'Uncategorized and miscellaneous expenses')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            m_dbConnection.Close();
        }
    }
}