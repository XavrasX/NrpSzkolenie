using System;

namespace NRP.KlientMvc.Models
{
    public interface IStatus
    {
        int Id { get; set; }
        string Nazwa { get; set; }
    }
}