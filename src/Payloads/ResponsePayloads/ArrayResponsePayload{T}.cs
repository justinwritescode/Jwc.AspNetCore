/*
 * ArrayResponsePayload{T}.cs
 *
 *   Created: 2022-11-20-07:14:18
 *   Modified: 2022-11-28-09:44:22
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Payloads;

using System.Xml.Serialization;
using JustinWritesCode.Payloads.Abstractions;

public class ArrayResponsePayload<T> : ResponsePayload<T[]>, IArrayResponsePayload<T>
{
    public ArrayResponsePayload()
        : this(Empty<T>())
    {
    }
    public ArrayResponsePayload(
        T[] values,
        string? stringValue = default,
        string? message = default,
        string itemSeparator = ArrayPayload<T>.DefaultItemSeparator)
        : base(values, stringValue, message)
    {
        ItemSeparator = itemSeparator;
        Message = message ?? string.Empty;
    }

    /// <summary>The arrray of values</summary>
    [JProp("values"), XmlAttribute("values"), JIgnore(Condition = JIgnoreCond.WhenWritingNull)]
    public virtual T[]? Values { get => Value; set => Value = value; }

    [JIgnore, XmlIgnore]
    public override T[]? Value { get => base.Value; set => base.Value = value ?? Empty<T>(); }

    /// <summary>The number of items in the array</summary>
    [JProp("count"), XmlAttribute("count")]
    public virtual int Count => Values.Length;

    public override string ToString() => _stringValue ?? Join(ItemSeparator, Values);

    private string? _stringValue;
    /// <summary>The string representation of the array</summary>
    /// <example>Foo, Bar, Baz</example>
    [JProp("stringValue"), XmlAttribute("stringValue"), JIgnore(Condition = JIgnoreCond.WhenWritingNull)]
    public override string? StringValue
    {
        get => _stringValue ?? ToString();
        set => _stringValue = value;
    }

    [JIgnore, XmlIgnore]
    public virtual string ItemSeparator { get; set; }
}