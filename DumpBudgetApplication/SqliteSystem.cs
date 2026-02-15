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

                string SqlTableExpenses = "create table tblexpenses (Category int not null, Price real not null, Description TEXT, Date TEXT )";
                SQLiteCommand command = new SQLiteCommand(SqlTableExpenses, m_dbConnection);
                command.ExecuteNonQuery();

                string SqlTableCategory = "create table categorylist (Category int not null ,Name TEXT not null, Description TEXT)";
                SQLiteCommand command2 = new SQLiteCommand(SqlTableCategory, m_dbConnection);
                command2.ExecuteNonQuery();

                string SqlTableIncome = "create table tblincome (Category int not null ,Amount Real, Description TEXT, Date TEXT)";
                SQLiteCommand command3 = new SQLiteCommand(SqlTableIncome, m_dbConnection);
                command3.ExecuteNonQuery();

                m_dbConnection.Close();

                CreateCategoryData();
                NewCreateRandomData();
                CreateIncomeData();
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

        static void NewCreateRandomData() /* Dump Data */
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=DBADataBase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql;

            // ============================================================
            // CATEGORY 1 - FOOD & KITCHEN
            // ============================================================

            // Monthly recurring expenses (Jan 2025 - Dec 2025)
            for (int month = 1; month <= 12; month++)
            {
                string date = $"15.{month:D2}.2025";

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (1, 1200, 'Monthly office kitchen grocery shopping (Coffee, Tea, Snacks)', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (1, 850, 'Staff lunch catering service', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            }

            // Occasional food expenses
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (1, 450, 'Client meeting breakfast expense', '12.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (1, 680, 'Team building dinner event', '28.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (1, 230, 'Bulk water order for office', '05.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (1, 520, 'Board meeting catering', '18.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (1, 390, 'Office celebration cake and refreshments', '14.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (1, 750, 'Client appreciation lunch', '22.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (1, 280, 'Emergency snack restock', '08.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (1, 620, 'Executive meeting lunch service', '25.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (1, 440, 'Summer picnic supplies', '15.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (1, 810, 'Quarterly review dinner', '30.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (1, 350, 'Holiday party catering', '20.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (1, 490, 'New Year celebration food', '31.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 2 - TRANSPORTATION
            // ============================================================

            // Monthly recurring transportation
            for (int month = 1; month <= 12; month++)
            {
                string date = $"10.{month:D2}.2025";

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (2, 1200, 'Company vehicle fuel cost', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (2, 180, 'Monthly parking subscription', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            }

            // Variable transportation expenses
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (2, 600, 'Taxi expenses for client visits', '18.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (2, 400, 'Vehicle maintenance and wash', '25.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (2, 520, 'Airport transfer service', '08.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (2, 750, 'Vehicle annual inspection and registration', '15.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (2, 340, 'Tire replacement service', '22.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (2, 480, 'Company car detailing', '12.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (2, 610, 'Delivery courier service', '28.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (2, 890, 'Vehicle brake system repair', '10.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (2, 270, 'Toll road charges', '18.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (2, 550, 'Vehicle air conditioning service', '05.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (2, 420, 'Emergency roadside assistance', '22.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (2, 380, 'Vehicle battery replacement', '14.11.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 3 - RENT
            // ============================================================

            for (int month = 1; month <= 12; month++)
            {
                string date = $"01.{month:D2}.2025";

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (3, 8500, 'Main office monthly rent payment', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (3, 600, 'Virtual office address service fee', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (3, 300, 'Building aidat (maintenance) contribution', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            }

            // Additional rental expenses
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (3, 1200, 'Conference room rental', '15.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (3, 850, 'Storage unit monthly fee', '20.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (3, 950, 'Event space rental', '10.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 4 - UTILITIES
            // ============================================================

            for (int month = 1; month <= 12; month++)
            {
                string date = $"05.{month:D2}.2025";

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (4, 450, 'Office electricity bill', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (4, 180, 'Water utility bill', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (4, 320, 'Natural gas heating bill', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (4, 250, 'Fiber internet service provider fee', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (4, 190, 'Corporate mobile line bill', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            }

            // Additional utility expenses
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (4, 380, 'Server cooling electricity surcharge', '15.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (4, 220, 'Additional phone lines installation', '22.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 5 - TAX & LEGAL
            // ============================================================

            // Quarterly tax payments
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (5, 3500, 'Q1 2025 Income Tax Payment', '15.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (5, 3500, 'Q2 2025 Income Tax Payment', '15.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (5, 3500, 'Q3 2025 Income Tax Payment', '15.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (5, 3500, 'Q4 2025 Income Tax Payment', '15.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Monthly VAT payments
            for (int month = 1; month <= 12; month++)
            {
                string date = $"20.{month:D2}.2025";

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (5, 1200, 'Monthly VAT payment', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (5, 1500, 'Accounting service monthly fee', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            }

            // Additional legal expenses
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (5, 180, 'Contract stamp duty expenses', '10.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (5, 450, 'Chamber of Commerce annual dues', '15.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (5, 2200, 'Legal consultation fee', '28.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (5, 850, 'Business license renewal', '12.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (5, 320, 'Notary public services', '18.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (5, 1750, 'Tax audit preparation fee', '25.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (5, 280, 'Corporate documentation updates', '14.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (5, 650, 'Trademark registration fee', '22.10.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 6 - OFFICE SUPPLIES
            // ============================================================

            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 350, 'Printer paper and toner cartridges', '08.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 150, 'Desk organizers and stationery', '15.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 200, 'Cleaning supplies for office', '22.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 420, 'Bulk office supply order', '05.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 280, 'Whiteboard markers and erasers', '18.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 310, 'File folders and binders', '12.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 190, 'Adhesive tape and glue supplies', '28.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 520, 'Printer maintenance kit', '15.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 240, 'Scissors, staplers and hole punchers', '05.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 380, 'Envelopes and mailing supplies', '22.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 290, 'Desk calendars and planners', '10.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 160, 'Label maker and labels', '25.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 440, 'Laminator and laminating pouches', '18.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 210, 'Paper clips and rubber bands', '08.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 350, 'Presentation materials and folders', '22.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 270, 'Desk lamps and batteries', '15.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 320, 'Coffee machine filters and supplies', '28.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (6, 480, 'Year-end supply bulk order', '15.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 7 - SOFTWARE & TECH
            // ============================================================

            // Monthly subscriptions
            for (int month = 1; month <= 12; month++)
            {
                string date = $"01.{month:D2}.2025";

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (7, 99, 'Cloud storage monthly subscription (AWS/Azure)', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (7, 180, 'Project management tool license', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            }

            // Annual subscriptions
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (7, 299, 'Annual software subscription license fee', '10.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (7, 210, 'Business email service annual fee', '15.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (7, 450, 'Antivirus software annual license', '20.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (7, 890, 'CRM system annual subscription', '05.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (7, 320, 'Video conferencing platform annual plan', '18.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (7, 540, 'Design software suite subscription', '25.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (7, 280, 'Password manager business plan', '12.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (7, 750, 'Database management system license', '28.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (7, 420, 'VPN service business subscription', '15.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (7, 380, 'Backup solution annual license', '22.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (7, 610, 'API integration platform subscription', '10.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (7, 270, 'Time tracking software license', '25.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (7, 520, 'Helpdesk ticketing system annual fee', '18.10.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 8 - HARDWARE
            // ============================================================

            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 4500, 'New laptop for design team', '15.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 1200, 'External monitors (dual setup)', '22.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 650, 'Mechanical keyboard and mouse set', '05.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 300, 'HDMI cables and power strips', '12.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 2200, 'Network switch upgrade', '28.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 850, 'Wireless router and access points', '15.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 3200, 'Server storage expansion', '22.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 480, 'USB hubs and docking stations', '10.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 920, 'Webcams for conference rooms', '25.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 1450, 'Ergonomic office chairs', '15.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 680, 'Standing desk converters', '28.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 1800, 'Printer and scanner combo unit', '12.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 420, 'External hard drives for backup', '25.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 750, 'Conference room projector', '18.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 540, 'Headsets for remote team', '05.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 2800, 'Laptop replacement (accounting dept)', '22.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 620, 'Surge protectors and UPS units', '15.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 1100, 'Network-attached storage device', '28.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 890, 'Office phone system upgrade', '15.10.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (8, 3600, 'Workstation for video editing', '25.11.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 9 - MARKETING
            // ============================================================

            // Monthly marketing expenses
            for (int month = 1; month <= 12; month++)
            {
                string date = $"10.{month:D2}.2025";

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (9, 1500, 'Google Ads campaign budget', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (9, 350, 'Email marketing platform fee', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            }

            // Campaign and promotional expenses
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 600, 'Social media sponsored posts', '15.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 280, 'Freelance graphic design service', '22.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 1200, 'Trade show booth rental', '05.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 450, 'Promotional merchandise printing', '18.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 820, 'Video production for advertisement', '12.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 680, 'LinkedIn sponsored content', '25.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 540, 'SEO optimization service', '15.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 920, 'Brand awareness campaign', '28.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 380, 'Content writing services', '18.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 750, 'Exhibition participation fee', '05.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 490, 'Instagram influencer collaboration', '22.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 1100, 'Website redesign project', '15.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 620, 'Press release distribution', '28.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 880, 'Product photography session', '18.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 420, 'Social media management tool', '05.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (9, 1450, 'Year-end promotional campaign', '15.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 10 - INSURANCE
            // ============================================================

            // Annual insurance payments
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (10, 11760, 'Annual office workspace insurance', '15.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (10, 9000, 'Annual company vehicle insurance', '20.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (10, 2400, 'Cyber liability insurance annual premium', '25.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (10, 1800, 'Professional liability insurance', '05.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Monthly employee health insurance
            for (int month = 1; month <= 12; month++)
            {
                string date = $"01.{month:D2}.2025";

                sql = $"insert into tblexpenses (Category, Price, Description, Date) values (10, 1200, 'Employee private health insurance', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            }

            // Additional insurance
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (10, 1500, 'Equipment insurance coverage', '15.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (10, 850, 'Business travel insurance', '22.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 11 - EDUCATION
            // ============================================================

            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 780, 'Staff professional training course', '20.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 320, 'Technical books and e-books', '05.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 180, 'Online certification exam fee', '18.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 1200, 'Leadership development workshop', '15.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 650, 'Project management certification', '28.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 890, 'Industry conference attendance', '15.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 420, 'Online learning platform subscription', '22.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 540, 'Communication skills training', '18.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 950, 'Technical certification exam and prep', '05.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 380, 'Professional development webinars', '22.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 720, 'Sales training program', '15.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 280, 'Time management workshop', '28.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 1100, 'Advanced Excel and data analysis course', '18.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 480, 'Cybersecurity awareness training', '05.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 820, 'Annual membership professional association', '22.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (11, 640, 'Customer service excellence training', '15.10.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 12 - TRAVEL
            // ============================================================

            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 3200, 'Hotel accommodation for business conference', '22.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 850, 'Domestic flight ticket for client meeting', '28.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 420, 'Car rental during business trip', '05.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 1800, 'International flight for trade show', '15.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 680, 'Hotel stay for regional meeting', '22.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 320, 'Business meal expenses during travel', '28.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 950, 'Round-trip flight for training', '15.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 540, 'Ground transportation and taxis', '22.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 2400, 'Multi-day conference hotel booking', '18.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 1100, 'Business class flight upgrade', '05.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 380, 'Per diem travel allowance', '22.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 1650, 'Executive retreat accommodation', '15.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 720, 'Train tickets for business travel', '28.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 890, 'Overseas client visit flight', '18.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 460, 'Airport lounge access membership', '05.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 2200, 'Team offsite meeting venue and stay', '22.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 580, 'Travel insurance for business trip', '15.10.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (12, 1350, 'Year-end business travel expenses', '15.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 13 - OTHER
            // ============================================================

            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 200, 'Miscellaneous office expenses', '10.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 120, 'Unexpected repair cost', '25.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 340, 'Petty cash replenishment', '05.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 580, 'Corporate gift purchases', '14.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 280, 'Office plant maintenance service', '28.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 450, 'Employee recognition awards', '15.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 190, 'Office security system maintenance', '28.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 620, 'Company event organizing fee', '15.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 310, 'First aid kit and supplies', '22.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 480, 'Charitable donation', '18.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 220, 'Locksmith service', '05.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 750, 'Air conditioning repair', '22.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 380, 'Pest control service', '15.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 540, 'Employee wellness program', '28.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 290, 'Emergency supplies purchase', '18.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 420, 'Bank service charges', '05.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 680, 'Office renovation minor works', '22.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 350, 'Lost and found item replacement', '15.10.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 520, 'Holiday decoration and setup', '01.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblexpenses (Category, Price, Description, Date) values (13, 240, 'Year-end miscellaneous expenses', '30.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            m_dbConnection.Close();
        }
        static void CreateIncomeData() /* Income Data */
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=DBADataBase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql;

            // ============================================================
            // CATEGORY 1 - PRODUCT SALES (Monthly recurring + variable)
            // ============================================================

            // Monthly product sales
            for (int month = 1; month <= 12; month++)
            {
                string date = $"15.{month:D2}.2025";

                sql = $"insert into tblincome (Category, Amount, Description, Date) values (1, 25000, 'Monthly product sales revenue', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            }

            // Additional product sales
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 8500, 'Bulk order from corporate client', '10.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 12000, 'Seasonal promotion sales', '20.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 15500, 'New product line launch sales', '05.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 9200, 'International export order', '18.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 18000, 'Trade show direct sales', '15.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 7800, 'Wholesale distributor payment', '28.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 21000, 'Spring collection sales', '12.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 11500, 'Retail chain bulk purchase', '25.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 16800, 'E-commerce platform sales', '10.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 13200, 'Government contract delivery', '22.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 28000, 'Mid-year clearance sales', '30.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 19500, 'Premium product line sales', '15.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 14300, 'Back-to-school sales campaign', '05.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 22000, 'Partnership collaboration sales', '20.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 17600, 'Autumn collection launch', '10.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 24500, 'Black Friday early sales', '15.11.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 35000, 'Holiday season peak sales', '15.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (1, 18900, 'Year-end clearance revenue', '28.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 2 - SERVICE REVENUE (Monthly + project-based)
            // ============================================================

            // Monthly service contracts
            for (int month = 1; month <= 12; month++)
            {
                string date = $"05.{month:D2}.2025";

                sql = $"insert into tblincome (Category, Amount, Description, Date) values (2, 18000, 'Monthly service contract revenue', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            }

            // Project-based services
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 12500, 'Website development project completion', '20.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 8700, 'Technical support service package', '08.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 15000, 'System integration project milestone', '22.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 9800, 'Maintenance and upgrade service', '15.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 22000, 'Enterprise software customization', '28.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 11200, 'Cloud migration service', '18.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 16500, 'Security audit and consulting', '05.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 13800, 'Mobile app development phase 1', '20.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 19500, 'Data analytics service package', '10.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 14200, 'IT infrastructure setup', '25.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 17800, 'Digital transformation consulting', '15.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 20500, 'Long-term project final payment', '28.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 12000, 'Emergency support service', '10.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (2, 25000, 'Year-end system overhaul project', '15.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 3 - CONSULTING REVENUE (Variable projects)
            // ============================================================

            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 8500, 'Business strategy consulting session', '15.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 12000, 'Management consulting retainer', '28.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 15500, 'Market research and analysis project', '12.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 9200, 'Process optimization consulting', '25.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 18000, 'Executive coaching program', '18.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 11500, 'Financial advisory service', '08.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 14800, 'HR transformation consulting', '22.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 16200, 'Risk management assessment', '15.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 13500, 'Change management workshop', '05.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 19000, 'Corporate restructuring advisory', '20.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 10800, 'Compliance consulting service', '18.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 21000, 'Strategic planning workshop series', '15.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 12500, 'Performance improvement consulting', '10.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 17500, 'Merger and acquisition advisory', '25.10.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (3, 14000, 'Annual strategy review session', '15.11.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 4 - SUBSCRIPTION REVENUE (Monthly recurring)
            // ============================================================

            for (int month = 1; month <= 12; month++)
            {
                string date = $"01.{month:D2}.2025";

                sql = $"insert into tblincome (Category, Amount, Description, Date) values (4, 12000, 'Software subscription revenue', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

                sql = $"insert into tblincome (Category, Amount, Description, Date) values (4, 8500, 'Platform access subscription fees', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

                sql = $"insert into tblincome (Category, Amount, Description, Date) values (4, 6200, 'Premium membership subscriptions', '{date}')";
                new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            }

            // Annual subscriptions
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (4, 25000, 'Enterprise annual subscription', '15.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (4, 18500, 'Corporate annual license renewal', '20.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (4, 22000, 'Multi-year subscription contract', '15.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (4, 15800, 'Educational institution subscription', '10.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 5 - LICENSE REVENUE (Variable)
            // ============================================================

            sql = @"insert into tblincome (Category, Amount, Description, Date) values (5, 35000, 'Software license sale to enterprise', '20.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (5, 18500, 'Intellectual property licensing fee', '15.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (5, 28000, 'Technology transfer agreement', '10.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (5, 22500, 'Patent licensing revenue', '25.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (5, 16800, 'Brand licensing agreement', '15.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (5, 31000, 'Multi-user license bulk sale', '20.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (5, 24000, 'Franchise licensing fee', '10.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (5, 19500, 'Content licensing revenue', '25.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (5, 27500, 'International distribution license', '15.11.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 6 - COMMISSION REVENUE (Variable)
            // ============================================================

            sql = @"insert into tblincome (Category, Amount, Description, Date) values (6, 5500, 'Sales commission from partner', '25.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (6, 8200, 'Referral commission revenue', '15.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (6, 6800, 'Affiliate marketing commission', '20.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (6, 12000, 'Broker commission from deals', '15.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (6, 7500, 'Agency commission revenue', '22.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (6, 9800, 'Partnership commission payment', '18.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (6, 11200, 'Channel partner commission', '25.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (6, 6500, 'Reseller commission revenue', '15.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (6, 13500, 'Strategic alliance commission', '20.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (6, 8900, 'Performance-based commission', '15.10.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (6, 10500, 'Year-end commission bonus', '20.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 7 - TRAINING REVENUE (Workshops & courses)
            // ============================================================

            sql = @"insert into tblincome (Category, Amount, Description, Date) values (7, 8500, 'Corporate training workshop revenue', '22.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (7, 12000, 'Professional certification course', '15.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (7, 6800, 'Online course enrollment fees', '10.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (7, 15500, 'Executive training program', '20.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (7, 9200, 'Technical skills workshop', '15.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (7, 11800, 'Leadership development seminar', '25.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (7, 7500, 'Summer intensive course revenue', '20.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (7, 13500, 'Industry conference training track', '15.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (7, 10200, 'Custom training program delivery', '20.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (7, 16000, 'Annual training package contract', '15.11.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 8 - INVESTMENT INCOME (Quarterly + occasional)
            // ============================================================

            // Quarterly dividends
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (8, 4500, 'Q1 Investment dividend income', '31.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (8, 4800, 'Q2 Investment dividend income', '30.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (8, 5200, 'Q3 Investment dividend income', '30.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (8, 5500, 'Q4 Investment dividend income', '31.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Interest income
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (8, 2200, 'Bank interest income', '15.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (8, 3500, 'Corporate bond interest', '20.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (8, 1800, 'Money market fund returns', '15.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (8, 2500, 'Fixed deposit maturity', '20.10.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // Capital gains
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (8, 12000, 'Stock portfolio capital gains', '25.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (8, 8500, 'Investment fund redemption profit', '15.11.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 9 - GRANT & FUNDING (Government & institutional)
            // ============================================================

            sql = @"insert into tblincome (Category, Amount, Description, Date) values (9, 45000, 'Government innovation grant', '20.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (9, 28000, 'Research and development funding', '15.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (9, 35000, 'Technology development subsidy', '10.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (9, 22000, 'Export promotion grant', '25.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (9, 18500, 'Workforce training subsidy', '15.10.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            // ============================================================
            // CATEGORY 10 - OTHER INCOME (Miscellaneous)
            // ============================================================

            sql = @"insert into tblincome (Category, Amount, Description, Date) values (10, 3500, 'Equipment rental income', '15.01.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (10, 5200, 'Asset sale proceeds', '20.02.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (10, 2800, 'Late payment fees collected', '15.03.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (10, 6500, 'Insurance claim settlement', '22.04.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (10, 4100, 'Foreign exchange gain', '15.05.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (10, 7800, 'Subcontracting revenue', '20.06.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (10, 3200, 'Scrap material sale', '15.07.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (10, 5600, 'Penalty revenue from contracts', '22.08.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (10, 4500, 'Miscellaneous service income', '15.09.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
            sql = @"insert into tblincome (Category, Amount, Description, Date) values (10, 8200, 'Year-end settlement income', '20.12.2025')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            m_dbConnection.Close();
        }

    }
}