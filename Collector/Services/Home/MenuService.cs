using System;
using System.Collections.Generic;
using Collector._Helpers._Translations;
using Collector.Models.Home;

namespace Collector.Services.Home
{
    public class MenuService
    {
        public List<MateriaisModel> ItensMenu()
        {
            return new List<MateriaisModel>
            {
                new MateriaisModel { Id=1, Imagem="ic_papel.png", Texto= AppResources.PaperTitle, Titulo=AppResources.PaperSubTitle, Descricao=AppResources.PaperText},
                new MateriaisModel { Id=2, Imagem="ic_aluminio.png", Texto=AppResources.AluminumTitle, Titulo=AppResources.AluminumSubTitle, Descricao=AppResources.AluminumText },
                new MateriaisModel { Id=3, Imagem="ic_plastico.png" , Texto=AppResources.PlasticTitle, Titulo=AppResources.PlasticSubTitle, Descricao=AppResources.PlasticText },
                new MateriaisModel { Id=4, Imagem="ic_oleo.png", Texto=AppResources.OilTitle, Titulo=AppResources.OilSubTitle, Descricao= AppResources.OilText  },
                new MateriaisModel { Id=5, Imagem="ic_diversos.png", Texto=AppResources.DiverseTitle, Titulo=AppResources.DiverseSubTitle, Descricao=AppResources.DiverseText  },
                new MateriaisModel { Id=6, Imagem="ic_metal.png" , Texto=AppResources.MetalTitle, Titulo=AppResources.MetalSubTitle, Descricao=AppResources.MetalText },
                new MateriaisModel { Id=7, Imagem="ic_podas.png", Texto=AppResources.TreePruningTitle, Titulo=AppResources.TreePruningSubTitle, Descricao=AppResources.TreePruningText},
                new MateriaisModel { Id=8, Imagem="ic_moveis.png", Texto=AppResources.FurnitureTitle, Titulo=AppResources.FurnitureSubTitle, Descricao=AppResources.FurnitureText },
                new MateriaisModel { Id=9, Imagem="ic_eletronicos.png", Texto=AppResources.ElectronicsTitle, Titulo=AppResources.ElectronicsSubTitle, Descricao=AppResources.ElectronicsText  },
                new MateriaisModel { Id=10, Imagem="ic_entulho.png" , Texto=AppResources.RubbleTitle, Titulo=AppResources.RubbleSubTitle, Descricao=AppResources.RubbleText },
                new MateriaisModel { Id=11, Imagem="ic_vidro.png" , Texto=AppResources.GlassTitle, Titulo=AppResources.GlassSubTitle, Descricao=AppResources.GlassText },
                new MateriaisModel { Id=12, Imagem="ic_bateria" , Texto=AppResources.BatteryTitle, Titulo=AppResources.BatterySubTitle, Descricao=AppResources.BatteryText },
            };
        }
    }
}