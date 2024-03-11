﻿namespace Sap.DTOs
{
    public class Processo
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public decimal precoVenda { get; set; }
        public decimal custo { get; set; }
        public int QtdeMarquinasUtilizadas { get; set; }
        public int horasEstimadas { get; set; }
        public string norma { get; set; }
        public int status { get; set; }
    }
}