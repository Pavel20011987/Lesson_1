using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Lesson_5_5_Exercise
{
    internal class ToDoTask
    {
        [JsonConstructor]
        public ToDoTask(string title) => Title = title;
        public string Title { get; set; }
        public bool IsDone { get; set; }

        internal void Done() => IsDone = true;

        #region Overrides of Object

        /// <inheritdoc />
        public override string ToString() => $"[{(IsDone ? "x" : " ")}] {Title}";

        #endregion
    }
}
