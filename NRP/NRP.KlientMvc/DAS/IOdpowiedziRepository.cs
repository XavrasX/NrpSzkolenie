using System.Collections.Generic;
using NRP.KlientMvc.Models;

namespace NRP.KlientMvc.DAS
{
    public interface IOdpowiedziRepository
    {
        void Dispose();
        List<v_Form_Odpowiedzi> GetOdpowiedzi();
        v_Form_Odpowiedzi GetOdpowiedzi(int id);
        void UpdateOdpowiedzi(IEnumerable<v_Form_Odpowiedzi> listaOdpowiedzi);
    }
}