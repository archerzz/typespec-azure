---
jsApi: true
title: "[F] getPropertyNames"

---
```ts
function getPropertyNames(context, property): [string, string]
```

Get the library and wire name of a model property. Takes `@clientName` and `@encodedName` into account

## Parameters

| Parameter | Type | Description |
| ------ | ------ | ------ |
| `context` | [`TCGCContext`](../interfaces/TCGCContext.md) |  |
| `property` | `ModelProperty` |  |

## Returns

[`string`, `string`]

a tuple of the library and wire name for a model property
