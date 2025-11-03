public class DataTypeExamples
{
    // fields
    // Primitive datatypes
    public string? StringValue;

    public int WholeNumber; // not empty, defaults to 0

    public double DecimalNumber;

    public char CharacterValue;

    public bool BooleanValue;

    // Collection of datatypes <--> data structures

    // Array -- fixed size (defined by the elements it contains)
    public string[]? ShoppingListAsArray;
    // List -- dynamically sized (can grow or shrink as we see fit)
    public List<string>? ShoppingListAsList;

}