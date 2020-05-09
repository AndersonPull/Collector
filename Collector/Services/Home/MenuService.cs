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
                new MateriaisModel { Id=1, IconGreen="ic_papel.png", IconWhite="ic_papelW.png", Texto= AppResources.PaperTitle, Titulo=AppResources.PaperSubTitle, Descricao=AppResources.PaperText, IsAtived = false, NoAtived = true},
                new MateriaisModel { Id=2, IconGreen="ic_aluminio.png", IconWhite="ic_aluminioW.png", Texto=AppResources.AluminumTitle, Titulo=AppResources.AluminumSubTitle, Descricao=AppResources.AluminumText, IsAtived = false, NoAtived = true },
                new MateriaisModel { Id=3, IconGreen="ic_plastico.png" , IconWhite="ic_plasticoW.png", Texto=AppResources.PlasticTitle, Titulo=AppResources.PlasticSubTitle, Descricao=AppResources.PlasticText, IsAtived = false, NoAtived = true },
                new MateriaisModel { Id=4, IconGreen="ic_oleo.png", IconWhite="ic_oleoW.png", Texto=AppResources.OilTitle, Titulo=AppResources.OilSubTitle, Descricao= AppResources.OilText, IsAtived = false, NoAtived = true },
                new MateriaisModel { Id=5, IconGreen="ic_diversos.png", IconWhite="ic_diversosW.png", Texto=AppResources.DiverseTitle, Titulo=AppResources.DiverseSubTitle, Descricao=AppResources.DiverseText, IsAtived = false, NoAtived = true},
                new MateriaisModel { Id=6, IconGreen="ic_metal.png", IconWhite="ic_metalW.png", Texto=AppResources.MetalTitle, Titulo=AppResources.MetalSubTitle, Descricao=AppResources.MetalText, IsAtived = false, NoAtived = true},
                new MateriaisModel { Id=7, IconGreen="ic_podas.png", IconWhite="ic_podasW.png", Texto=AppResources.TreePruningTitle, Titulo=AppResources.TreePruningSubTitle, Descricao=AppResources.TreePruningText, IsAtived = false, NoAtived = true},
                new MateriaisModel { Id=8, IconGreen="ic_moveis.png", IconWhite="ic_moveisW.png", Texto=AppResources.FurnitureTitle, Titulo=AppResources.FurnitureSubTitle, Descricao=AppResources.FurnitureText, IsAtived = false, NoAtived = true},
                new MateriaisModel { Id=9, IconGreen="ic_eletronicos.png", IconWhite="ic_eletronicosW.png", Texto=AppResources.ElectronicsTitle, Titulo=AppResources.ElectronicsSubTitle, Descricao=AppResources.ElectronicsText, IsAtived = false, NoAtived = true},
                new MateriaisModel { Id=10, IconGreen="ic_entulho.png", IconWhite="ic_entulhoW.png", Texto=AppResources.RubbleTitle, Titulo=AppResources.RubbleSubTitle, Descricao=AppResources.RubbleText, IsAtived = false, NoAtived = true},
                new MateriaisModel { Id=11, IconGreen="ic_vidro.png", IconWhite="ic_vidroW.png", Texto=AppResources.GlassTitle, Titulo=AppResources.GlassSubTitle, Descricao=AppResources.GlassText, IsAtived = false, NoAtived = true},
                new MateriaisModel { Id=12, IconGreen="ic_bateria.png", IconWhite="ic_bateriaW.png", Texto=AppResources.BatteryTitle, Titulo=AppResources.BatterySubTitle, Descricao=AppResources.BatteryText, IsAtived = false, NoAtived = true},
            };
        }
    }
}