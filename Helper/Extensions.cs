using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Extensions
{
    public static class Extension
    {
        //public static void LogException(this Exception ex, string info = "")
        //{
        //    var message = ex.Message + Environment.NewLine + ex.StackTrace;
        //    if (!string.IsNullOrEmpty(info)) { message = info + Environment.NewLine + message; }
        //    Logging.Log(message, LogType.Error);
        //}

        public static string InvertIp(this string value)
        {
            var temp = value.Split(new char[] { '.' });
            var r =string.Join(".",  temp.Reverse());
            return r;
        }

       

        public static void AddRange<T>(this ConcurrentBag<T> bag, IEnumerable<T> toAdd)
        {
            foreach (var element in toAdd)
            {
                bag.Add(element);
            }
        }

        public static void Clear<T>(this ConcurrentBag <T> bag)
        {
            if (bag != null)
            {
                while (!bag.IsEmpty)
                    bag.TryTake(out var x);
            }
        }

        /// <summary>
        /// Turn a controlcollection into a List<Control> for better linq support.
        /// </summary>
        /// <param name="ctrlcollection"></param>
        /// <returns></returns>
        public static IEnumerable<Control> ToList(this Control.ControlCollection ctrlcollection)
        {
            return ctrlcollection.Cast<Control>().ToList();
            //var list = new List<Control>();
            
            //foreach (Control c in ctrlcollection)
            //{
            //    list.Add(c);
            //}
            //return list;
        }

        /// <summary>
        /// Takes all controls of the given type T within the rootControl. 
        /// And then calls the method again for all controls contained by that control.
        /// SelectMany flattens the nested lists into one list.
        /// 
        /// usage: var allCtrlsOfType = GetAllOfType<ControlType>(ContainerControl)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rootControl"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetAllOfType<T>(this Control rootControl)
        {
            return rootControl.Controls.OfType<T>().
                   Concat(rootControl.Controls.OfType<Control>().SelectMany(GetAllOfType<T>));

        }

        /// <summary>
        /// Non blocking delay funtion.
        /// </summary>
        /// <param name="interval">The delay interval. Min interval 10 ms, default 100ms. </param>
        /// <returns>
        /// "false" when the dely interval is over. 
        /// </returns>
        public static bool Delay(this object obj, int interval = 100)
        {
            var start = DateTime.Now;
            var target = new TimeSpan(start.AddMilliseconds(100).Ticks);
            while (DateTime.Now - start > target) { Application.DoEvents(); }
            return false;
        }


        /// <summary>
        /// Change fontcolor an fontstyle of certain words.
        /// Error - red, Info - blue, Warning - orange
        /// </summary>
        /// <param name="rtb"></param>
        //public static void ColorizeTags(this RichTextBox rtb)
        //{
        //    var tags = Enum.GetValues(typeof(LogType)).Cast<LogType>().Select(v => v.ToString());
        //    var color = Color.Black;
        //    var font = new Font("Segoe UI", 11, FontStyle.Underline);
        //    foreach (string tag in tags)
        //    {
        //        if (tag.Equals(LogType.Error.ToString())) { color = Color.Red; } else if (tag.Equals(LogType.Warning.ToString())) { color = Color.Orange; } else if (tag.Equals(LogType.Info.ToString())) { color = Color.Blue; } else if (tag.Equals(LogType.Success.ToString())) { color = Color.Green; } else if (tag.Equals(LogType.Fail.ToString())) { color = Color.OrangeRed; }

        //        var matchString = Regex.Escape(tag);
        //        foreach (Match match in Regex.Matches(rtb.Text, matchString))
        //        {
        //            rtb.Select(match.Index, tag.Length);
        //            rtb.SelectionColor = color;
        //            rtb.SelectionFont = font;
        //            rtb.Select(rtb.TextLength, 0);
        //            rtb.SelectionColor = rtb.ForeColor;
        //        }
        //    }
        //}

        /// <summary>
        /// Check if an IEnumerabel is empty.
        /// </summary
        /// <param name="src">enumeration to check.</param>
        /// <returns>A bool.</returns>
        public static bool IsEmpty<T>(this IEnumerable<T> src)
        {
            if (src.Count() == 0) { return true; }
            return false;
        }

        
      
        #region Numeric
        /// <summary>
        /// Read a double value from a control with "Text" property. 
        /// </summary>
        /// <param name="control">Textbox, Label, Combobox</param>
        /// <returns></returns>
        public static double GetDoubleValue(this Control control,int decimals=2)
        {
            if (control is TextBox || control is Label || control is ComboBox)
            {
                if (double.TryParse(control.Text, out var value))
                { return Math.Round(value,decimals); }
            }
            return double.NaN;
        }

        /// <summary>
        /// Read an integer value from a control with "Text" property. 
        /// </summary>
        /// <param name="control">Textbox, Label, Combobox</param>
        /// <returns></returns>
        public static int GetIntValue(this Control control)
        {
            if (control is TextBox || control is Label || control is ComboBox)
            {
                if (int.TryParse(control.Text, out var value))
                { return value; }
            }
            return 0;
        }

        /// <summary>
        /// Read an ulong value from a control with "Text" property. 
        /// </summary>
        /// <param name="control">Textbox, Label, Combobox</param>
        /// <returns></returns>
        public static ulong GetUlongValue(this Control control)
        {
            if (control is TextBox || control is Label || control is ComboBox)
            {
                if (ulong.TryParse(control.Text, out var value))
                { return value; }
            }
            return 0;
        }

        /// <summary>
        /// Extract an integer value from a string. 
        /// </summary>
        /// <param name="string"></param>
        /// <returns></returns>
        public static int ToNumberOnly(this string s)
        {
            if (string.IsNullOrEmpty(s)) { return 0; }
            var substr = string.Join("", s.ToCharArray().Where(Char.IsDigit));
            if (int.TryParse(substr, out var result)) { return result; }
            return 0;
        }

        /// <summary>
        /// Extract an integer value from a string. 
        /// </summary>
        /// <param name="string"></param>
        /// <returns></returns>
        public static string IncreaseNumber(this string s)
        {
            if (string.IsNullOrEmpty(s)) { return null; }
            var substr = string.Join("", s.ToCharArray().Where(Char.IsDigit));
            if (int.TryParse(substr, out var result))
            { return string.Concat(s.Replace(substr, ""), (result + 1).ToString()); }
            return null;
        }

        /// <summary>
        /// Check if the given object is a numeric type 
        /// or if it is a string representation of a number. 
        /// e.g. string str=12.345; str.IsNumber() --> True               
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True/ False</returns>
        public static bool IsNumber(this object value)
        {
            if (value == null) { return false; }
            if (value is string)
            {
                double d = 0;
                return double.TryParse(value.ToString(), out d);
            }
            return value is sbyte
                    || value is byte
                    || value is short
                    || value is ushort
                    || value is int
                    || value is uint
                    || value is long
                    || value is ulong
                    || value is float
                    || value is double
                    || value is decimal
                    || value is UInt16
                    || value is UInt64;
        }

        #endregion


        /// <summary>
        /// make the description of an enum bindable.
        /// usge: object.DataSource= object.BindEnumDescription(typeof(...));
        ///         object.DisplayMember = "Description";
        ///         object.ValueMember = "value";
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static object BindEnumDescription(Type e)
        {
            var ret = Enum.GetValues(e).Cast<Enum>().Select(value => new{(Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,value
            }).OrderBy(item => item.value).ToList();

            return ret;
        }

       


        /// <summary>
        /// parsens a string from description tag
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string ToDescriptionString<T>(this T val) where T : IConvertible
        {
            if (val is Enum)
            {
                DescriptionAttribute[] attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
                return attributes.Length > 0 ? attributes[0].Description : string.Empty;
            }
            return (val as Enum).ToString();

        }

        /// <summary>
        /// parses an enum from description bound enums. 
        /// If no description or no binding is there the element will be parsed.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        public static T ToEnum<T>(this object o)
        {
            if (o != null)
            {
                string x = o.ToString();
                if (x.Contains("="))
                {
                    x = x.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[1];
                    x = x.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries)[1];

                    x = x.Trim(new char[] { '}', '{' });
                    x = x.Trim();
                }
                if (!string.IsNullOrEmpty(x) && Enum.IsDefined(typeof(T), x))
                {
                    T enumVal = (T)Enum.Parse(typeof(T), x);
                    return enumVal;
                } else
                {
                    return default(T);
                }
            } else
            { return default(T); }
        }


        #region Gimmicks
        /// <summary>
        /// Fade in a Form. Place this e.g. inside the OnLoad override
        /// </summary>
        /// <param name="FormToFadeIn"></param>
        /// <param name="latency">the bigger the number, the slower the fading effect</param>
        public static void FadeIn(this Form FormToFadeIn, int latency = 50)
        {
            float Step = 1f / latency;
            for (int b = 0; b < latency; b++)
            {
                FormToFadeIn.Opacity = b * Step;
                FormToFadeIn.Refresh();
            }
            FormToFadeIn.Opacity = 1.0d;
            FormToFadeIn.Refresh();
        }
        /// <summary>
        /// Fade in a Form. Place this e.g. inside the OnLoad override
        /// </summary>
        /// <param name="FormToFadeIn"></param>
        /// <param name="latency">the bigger the number, the slower the fading effect</param>
        public static void FadeOut(this Form FormToFadeout, int latency = 50)
        {
            float Step = 1f / latency;
            for (int b = latency; b > 0; b--)
            {
                FormToFadeout.Opacity = b * Step;
                FormToFadeout.Refresh();
            }
            FormToFadeout.Opacity = 0;
            FormToFadeout.Refresh();
        }

        #endregion
    }
}