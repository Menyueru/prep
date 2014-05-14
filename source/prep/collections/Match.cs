﻿using System;
using prep.utility.filtering;

namespace prep.collections
{
  public class Match<ItemToMatch>
  {
    public static MatchFactory<ItemToMatch, AttributeType> with_attribute<AttributeType>(
      AttributeAccessor<ItemToMatch, AttributeType> accessor)
    {
      return new MatchFactory<ItemToMatch, AttributeType>(accessor);
    }

    public static ComparableMatchFactory<ItemToMatch, AttributeType> with_comparable_attribute<AttributeType>(
      AttributeAccessor<ItemToMatch, AttributeType> accessor) where AttributeType : IComparable<AttributeType>
    {
      return new ComparableMatchFactory<ItemToMatch, AttributeType>(accessor,
        with_attribute(accessor));
    }
  }
}