using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace IphoneCSharp.Models
{
    public class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider)
        {
            using(var context = new IphoneCSarpContext (serviceProvider.GetRequiredService<DbContextOptions<IphoneCSarpContext>>()))
            {
                if (context.IphoneModel.Any())
                {
                    return; // DB SEEDED
                }

                context.IphoneModel.AddRange(
                    new IphoneModel
				{
                    HUP_TIER = "Apportez votre Téléphone",
                    PRICE = 919,
				},
					new IphoneModel
					{
						HUP_TIER = "Petit",
						PRICE = 649,
					},
					new IphoneModel
					{
						HUP_TIER = "Petit",
						PRICE = 649,
					},
					new IphoneModel
					{
						HUP_TIER = "Moyen",
						PRICE = 369,
					},
					new IphoneModel
					{
						HUP_TIER = "Moyen",
						PRICE = 369,
					},
					new IphoneModel
					{
						HUP_TIER = "Grand",
						PRICE = 249,
					},
					new IphoneModel
					{
						HUP_TIER = "Grand",
						PRICE = 249,
					}
                );
                context.SaveChanges(); 
            }
                
        }
    }
}
