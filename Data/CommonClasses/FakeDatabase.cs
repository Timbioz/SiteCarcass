using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using WebSite.Models;


namespace WebSite.Data
{
    public class FakeDatabase : DropCreateDatabaseIfModelChanges<SiteDbContext>
    {
        protected override void Seed(SiteDbContext context)
        {
            var settings = new List<Settings>
                               {
                                   new Settings
                                       {
                                           Name = "Fake1",
                                           Description =
                                               "Fake 1. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                           Value = "12.03.2008",
                                           Enabled = true
                                       },
                                   new Settings
                                       {
                                           Name = "Fake2",
                                           Description =
                                               "Fake 2. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                           Value = "12.369",
                                           Enabled = true
                                       },
                                   new Settings
                                       {
                                           Name = "Fake3",
                                           Description =
                                               "Fake 3. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                           Value = "Volkov Artem",
                                           Enabled = true
                                       },
                                   new Settings
                                       {
                                           Name = "Fake4",
                                           Description =
                                               "Fake 4. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                           Value = "true",
                                           Enabled = false
                                       },
                                   new Settings
                                       {
                                           Name = "Fake5",
                                           Description =
                                               "Fake 5. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                           Value = "12.03.2008 15:26",
                                           Enabled = true
                                       },
                                   new Settings
                                       {
                                           Name = "Fake6",
                                           Description =
                                               "Fake 6. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                           Value = "GuId",
                                           Enabled = false
                                       },
                                   new Settings
                                       {
                                           Name = "Fake7",
                                           Description =
                                               "Fake 7. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                           Value = "September",
                                           Enabled = true
                                       },
                                   new Settings
                                       {
                                           Name = "Fake8",
                                           Description =
                                               "Fake 8. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                           Value = "false",
                                           Enabled = true
                                       },
                                   new Settings
                                       {
                                           Name = "Fake9",
                                           Description =
                                               "Fake 9. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                           Value = "158.3336",
                                           Enabled = false
                                       },
                                   new Settings
                                       {
                                           Name = "Fake10",
                                           Description =
                                               "Fake 10. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                           Value = "http://google.com",
                                           Enabled = false
                                       },
                                   new Settings
                                       {
                                           Name = "Fake11",
                                           Description =
                                               "Fake 11. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                           Value = "Ghost",
                                           Enabled = true
                                       },
                                   new Settings
                                       {
                                           Name = "Fake12",
                                           Description =
                                               "Fake 12. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                           Value = "15",
                                           Enabled = false
                                       }
                               };
            settings.ForEach(s => context.Settings.Add(s));
            context.SaveChanges();

            var sections = new List<Sections>
                               {
                                   new Sections
                                       {
                                           Name = "Fake1",
                                           Description =
                                               "Fake 1. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                       },
                                   new Sections
                                       {
                                           Name = "Fake2",
                                           Description =
                                               "Fake 2. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                       },
                                   new Sections
                                       {
                                           Name = "Fake3",
                                           Description =
                                               "Fake 3. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                       },
                                   new Sections
                                       {
                                           Name = "Fake4",
                                           Description =
                                               "Fake 4. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                       },
                                   new Sections
                                       {
                                           Name = "Fake5",
                                           Description =
                                               "Fake 5. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                       },
                                   new Sections
                                       {
                                           Name = "Fake6",
                                           Description =
                                               "Fake 6. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                       },
                                   new Sections
                                       {
                                           Name = "Fake7",
                                           Description =
                                               "Fake 7. Pellentesque mauris tristique vut rhoncus cras, in parturient tempor sit eros, rhoncus urna!",
                                       },
                               };
            sections.ForEach(s => context.Sections.Add(s));
            context.SaveChanges();

            //var settingsCategories = new List<Category>
            //                             {
            //                                 new Category
            //                                     {
            //                                         Name = "FakeCategory1",
            //                                         Description =
            //                                             "In elementum Fake 1 mattis, pulvinar dapibus! Urna? Amet duis? Aenean sed tincidunt aliquet?"
            //                                     },
            //                                 new Category
            //                                     {
            //                                         Name = "FakeCategory2",
            //                                         Description =
            //                                             "In elementum Fake 2 mattis, pulvinar dapibus! Urna? Amet duis? Aenean sed tincidunt aliquet?"
            //                                     },
            //                                 new Category
            //                                     {
            //                                         Name = "FakeCategory3",
            //                                         Description =
            //                                             "In elementum Fake 3 mattis, pulvinar dapibus! Urna? Amet duis? Aenean sed tincidunt aliquet?"
            //                                     },
            //                                 new Category
            //                                     {
            //                                         Name = "FakeCategory4",
            //                                         Description =
            //                                             "In elementum Fake 4 mattis, pulvinar dapibus! Urna? Amet duis? Aenean sed tincidunt aliquet?"
            //                                     },
            //                                 new Category
            //                                     {
            //                                         Name = "FakeCategory5",
            //                                         Description =
            //                                             "In elementum Fake 5 mattis, pulvinar dapibus! Urna? Amet duis? Aenean sed tincidunt aliquet?"
            //                                     },
            //                                 new Category
            //                                     {
            //                                         Name = "FakeCategory6",
            //                                         Description =
            //                                             "In elementum Fake 6 mattis, pulvinar dapibus! Urna? Amet duis? Aenean sed tincidunt aliquet?"
            //                                     },
            //                                 new Category
            //                                     {
            //                                         Name = "FakeCategory7",
            //                                         Description =
            //                                             "In elementum Fake 7 mattis, pulvinar dapibus! Urna? Amet duis? Aenean sed tincidunt aliquet?"
            //                                     }
            //                             };
            //settingsCategories.ForEach(s => context.Category.Add(s));
            //context.SaveChanges();


        }
    }
}
