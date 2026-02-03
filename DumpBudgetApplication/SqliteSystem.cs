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

            sql = @"insert into tableitems (Category, Price, Description) 
            values (1, 250, 'Daily grocery purchase including basic food items')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (2, 120, 'Monthly public transportation card expense')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (3, 4500, 'Monthly apartment rent payment')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (4, 600, 'Electricity and water utility bills')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (5, 900, 'Clothing and personal shopping expenses')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (6, 350, 'Medical consultation and pharmacy costs')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (7, 780, 'Online professional training course fee')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (8, 400, 'Cinema and weekend entertainment activities')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (9, 3200, 'Hotel accommodation for business travel')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (11, 550, 'Business lunch with external clients')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (13, 299, 'Annual software subscription license fee')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (15, 1500, 'Online marketing and advertising campaign cost')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (16, 1100, 'Quarterly tax and government fee payment')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (22, 980, 'Annual health insurance premium payment')";
            new SQLiteCommand(sql, m_dbConnection).ExecuteNonQuery();

            sql = @"insert into tableitems (Category, Price, Description) 
            values (27, 200, 'Miscellaneous and uncategorized expenses')";
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
