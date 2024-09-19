using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Parcial2Rec.Presentacion.Presentadores.Comun;

public class ModelDataValidation
{
    public void Validate(object model)
    {
        if (model == null)
        {
            throw new ArgumentNullException(nameof(model));
        }

        var results = new List<ValidationResult>();
        var context = new ValidationContext(model);
        bool isValid = Validator.TryValidateObject(model, context, results, true);

        if (!isValid)
        {
            var errorMessage = results.Select(r => "- " + r.ErrorMessage).Aggregate((current, next) => current + "\n" + next);
            throw new Exception(errorMessage);
        }
    }
}

