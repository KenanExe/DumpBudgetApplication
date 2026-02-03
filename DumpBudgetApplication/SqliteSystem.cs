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

                //Table Creation
                string SqlTable = "create table tableitems (Category int not null, Price real not null , Description TEXT)";

                SQLiteCommand command = new SQLiteCommand(SqlTable, m_dbConnection);
                command.ExecuteNonQuery();
                string SqlTable2 = "create table categorylist (Category int not null ,Name TEXT not null, Description TEXT)";
                SQLiteCommand command2 = new SQLiteCommand(SqlTable2, m_dbConnection);
                command2.ExecuteNonQuery();

                m_dbConnection.Close();
                CreateRandomData();
                CreateCategoryData();
            }
        }

       static void CreateRandomData() /* Dump Data */
    {
    SQLiteConnection m_dbConnection;
    m_dbConnection = new SQLiteConnection("Data Source=DBADataBase.sqlite;Version=3;");
    m_dbConnection.Open();

    string sql;

    // Category 1 - Food
    sql = @"insert into tableitems (Category, Price, Description) values (1, 120, 'Weekly grocery shopping for basic food items')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (1, 85, 'Lunch meal purchased during work hours')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (1, 45, 'Breakfast coffee and pastry expense')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (1, 230, 'Monthly bulk grocery purchase')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (1, 60, 'Evening takeaway food order')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (1, 140, 'Fresh fruit and vegetable market shopping')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (1, 90, 'Snacks and beverages purchase')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

    // Category 2 - Transportation
    sql = @"insert into tableitems (Category, Price, Description) values (2, 120, 'Monthly public transportation card expense')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (2, 60, 'Taxi ride for urgent travel')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (2, 180, 'Fuel cost for personal vehicle usage')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (2, 40, 'Parking fee in city center')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (2, 95, 'Intercity bus ticket purchase')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

    // Category 3 - Rent
    sql = @"insert into tableitems (Category, Price, Description) values (3, 4500, 'Monthly apartment rent payment')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (3, 300, 'Shared building maintenance contribution')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (3, 150, 'Storage room rental fee')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (3, 500, 'Office space monthly rent payment')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (3, 250, 'Annual rent contract administration cost')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

    // Category 4 - Utilities
    sql = @"insert into tableitems (Category, Price, Description) values (4, 320, 'Monthly electricity bill payment')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (4, 180, 'Water utility bill payment')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (4, 210, 'Natural gas heating bill')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (4, 160, 'Internet service provider monthly fee')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (4, 95, 'Mobile phone service bill')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

    // Category 5 - Shopping
    sql = @"insert into tableitems (Category, Price, Description) values (5, 900, 'Clothing and personal shopping expenses')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (5, 450, 'Online electronics accessory purchase')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (5, 300, 'Seasonal clothing discount purchase')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (5, 120, 'Daily retail store shopping')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (5, 680, 'Shoe and apparel purchase')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

    // Category 6 - Health
    sql = @"insert into tableitems (Category, Price, Description) values (6, 350, 'Medical consultation and pharmacy costs')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (6, 220, 'Dental check-up and treatment fee')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (6, 140, 'Prescription medicine purchase')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (6, 500, 'Private hospital examination fee')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (6, 90, 'Over-the-counter health products')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

    // Category 7 - Education
    sql = @"insert into tableitems (Category, Price, Description) values (7, 780, 'Online professional training course fee')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (7, 320, 'Technical book and study material purchase')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (7, 450, 'Language course enrollment fee')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (7, 180, 'Online certification exam fee')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (7, 95, 'Educational seminar attendance cost')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

    // Category 8 - Entertainment
    sql = @"insert into tableitems (Category, Price, Description) values (8, 400, 'Cinema and weekend entertainment activities')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (8, 250, 'Concert ticket purchase')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (8, 180, 'Online game subscription payment')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (8, 130, 'Streaming service monthly subscription')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (8, 95, 'Weekend social activity expense')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

    // Category 9 - Travel
    sql = @"insert into tableitems (Category, Price, Description) values (9, 3200, 'Hotel accommodation for business travel')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (9, 850, 'Domestic flight ticket purchase')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (9, 420, 'Car rental during vacation period')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (9, 300, 'Travel insurance policy cost')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (9, 150, 'Local transportation during travel')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

    // Category 13 - Software Subscription
    sql = @"insert into tableitems (Category, Price, Description) values (13, 299, 'Annual software subscription license fee')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (13, 99, 'Cloud storage monthly subscription')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (13, 180, 'Project management tool license')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (13, 75, 'Code editor premium features subscription')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (13, 210, 'Business email service annual fee')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

    // Category 15 - Marketing
    sql = @"insert into tableitems (Category, Price, Description) values (15, 1500, 'Online marketing and advertising campaign cost')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (15, 600, 'Social media advertisement budget')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (15, 420, 'Search engine advertisement expenses')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (15, 280, 'Graphic design service for promotion materials')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (15, 350, 'Email marketing platform usage fee')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

    // Category 22 - Insurance
    sql = @"insert into tableitems (Category, Price, Description) values (22, 980, 'Annual health insurance premium payment')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (22, 750, 'Vehicle insurance annual renewal fee')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (22, 420, 'Home insurance policy payment')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (22, 300, 'Travel insurance coverage cost')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (22, 260, 'Supplementary private insurance payment')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

    // Category 27 - Other
    sql = @"insert into tableitems (Category, Price, Description) values (27, 200, 'Miscellaneous and uncategorized expenses')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (27, 120, 'Unexpected daily expense')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (27, 75, 'Minor unplanned purchase')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (27, 340, 'Emergency miscellaneous payment')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();
    sql = @"insert into tableitems (Category, Price, Description) values (27, 95, 'General cash expense without category')";
    new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

    m_dbConnection.Close();
}


        static void CreateCategoryData() /* Dump Data*/
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=DBADataBase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql;

            sql = @"insert into categorylist (Category, Name, Description) values (1, 'Food', 'Daily food and grocery expenses')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (2, 'Transportation', 'Public transport, fuel, taxi, and travel-related transport costs')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (3, 'Rent', 'House or office rental payments')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (4, 'Utilities', 'Electricity, water, gas, internet, and phone bills')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (5, 'Shopping', 'Clothing, electronics, and general shopping expenses')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (6, 'Health', 'Medical, pharmacy, and healthcare expenses')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (7, 'Education', 'Courses, books, and education-related payments')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (8, 'Entertainment', 'Cinema, concerts, games, and leisure activities')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (9, 'Travel', 'Accommodation, tickets, and travel expenses')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (10, 'Personal Care', 'Haircut, cosmetics, and personal care services')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (11, 'Business Meal', 'Meals spent for business purposes')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (12, 'Office Expenses', 'Office supplies and work-related expenses')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (13, 'Software Subscription', 'Paid software, licenses, and online services')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (14, 'Hardware', 'Computers, phones, and other hardware purchases')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (15, 'Marketing', 'Advertising and marketing expenses')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (16, 'Tax', 'Taxes, fees, and government charges')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (17, 'Home Supplies', 'Furniture and household items')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (18, 'Maintenance', 'Repair and maintenance costs')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (19, 'Pet Expenses', 'Food, vet, and care expenses for pets')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (20, 'Child Expenses', 'Education and daily expenses for children')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (21, 'Loan Payment', 'Loan and debt repayments')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (22, 'Insurance', 'Health, car, home, or other insurance payments')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (23, 'Investment', 'Money spent on investments')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (24, 'Savings', 'Transferred amount for savings')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (25, 'Donation', 'Charity and donation expenses')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (26, 'Gift', 'Gifts and special occasion spending')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into categorylist (Category, Name, Description) values (27, 'Other', 'Uncategorized or miscellaneous expenses')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            m_dbConnection.Close();


        }


    }
}
