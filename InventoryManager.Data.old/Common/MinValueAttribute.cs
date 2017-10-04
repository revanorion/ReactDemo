using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.Business.Common
{
    public class MinValueAttribute : ValidationAttribute, IClientValidatable
    {
        private readonly int _minValue;

        public MinValueAttribute(int minValue)
        {
            _minValue = minValue;
            ErrorMessage = "Enter a value greater than or equal to " + _minValue;
        }

        public override bool IsValid(object value)
        {
            return Convert.ToInt32(value) >= _minValue;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule();
            rule.ErrorMessage = ErrorMessage;
            rule.ValidationParameters.Add("min", _minValue);
            rule.ValidationParameters.Add("max", Int32.MaxValue);
            rule.ValidationType = "range";
            yield return rule;
        }
    }
}