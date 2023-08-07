using System;
using System.Net;

namespace Ky.Hbe.WorkerPortal.Infrastructure.Model
{
    public class KYKeyValuePair<TKey, TValue>
    {
        //
        // Summary:
        //     Initializes a new instance of the System.Collections.Generic.MyKeyValuePair<TKey,TValue>
        //     structure with the specified key and value.
        //
        // Parameters:            //   key:
        //     The object defined in each key/value pair.
        //
        //   value:
        //     The definition associated with key.
        public KYKeyValuePair(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        // Summary:
        //     Gets the key in the key/value pair.
        //
        // Returns:
        //     A TKey that is the key of the System.Collections.Generic.MyKeyValuePair<TKey,TValue>.
        public TKey _key { get; set; }
        public TKey Key { get; set; }
        //
        // Summary:
        //     Gets the value in the key/value pair.
        //
        // Returns:
        //     A TValue that is the value of the System.Collections.Generic.MyKeyValuePair<TKey,TValue>.
        public TValue Value { get; set; }

        // Summary:
        //     Returns a string representation of the System.Collections.Generic.MyKeyValuePair<TKey,TValue>,
        //     using the string representations of the key and value.
        //
        // Returns:
        //     A string representation of the System.Collections.Generic.MyKeyValuePair<TKey,TValue>,
        //     which includes the string representations of the key and value.
        public override string ToString()
        {
            string ret_val = string.Empty;

            if (Value is String)
                ret_val = Value as String;
            else
                ret_val = Value.ToString();

            return ret_val;
        }
    }
}