namespace lubee_web_api.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        public int ContractId { get; set; }
        public int ItemId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Enable { get; set; }
        public int Deleted { get; set; }
        public string CreatedBy { get; set; }

        // Propiedad de navegación para la relación con Contrato
        [ForeignKey("ContractId")]
        public Contrato Contrato { get; set; }
        [ForeignKey("ItemId")]
        public Producto Producto { get; set; }

    }
}

