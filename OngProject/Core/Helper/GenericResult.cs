using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Core.Helper
{
    public class GenericResult<T>
    {
        public GenericResult(T data)
        {
            _object = data;
        }
        /// <summary>
        /// Allows you to know info about your request
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Allows you to know status about your request
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// If exist list of errors
        /// </summary>
        public IEnumerable<string> Errors { get; set; }
        /// <summary>
        /// requested object
        /// </summary>
        public T _object { get; set; }
    }
}
