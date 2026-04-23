# Tdd.TimeBookings (C#)

TDD workshop template for C# using xUnit and Shouldly, set up for Visual Studio 2026.

## Specification

A time booking covers a single period of work with an optional break.

- **Total working time** (excluding any break): 30 min – 8 h
- **Optional break**: 30 min – 1 h (at most one)
- **Each continuous working block**: 30 min – 6 h — the whole booking when
  no break is taken, or each segment before/after the break

### Shape

```
    ┌───────── Total working: 30 min – 8 h ──────────┐
    ┌──────────────┐ ┌╌╌╌╌╌╌╌╌╌╌╌╌╌╌┐ ┌╌╌╌╌╌╌╌╌╌╌╌╌╌╌┐
    │  Working A   │ ╎   Break      ╎ ╎  Working B   ╎
    │ 30 min – 6 h │ ╎ 30 min – 1 h ╎ ╎ 30 min – 6 h ╎
    └──────────────┘ └╌╌╌╌╌╌╌╌╌╌╌╌╌╌┘ └╌╌╌╌╌╌╌╌╌╌╌╌╌╌┘
                     └────────── optional ───────────┘
```

## Running the tests

1. Open `Tdd.slnx` in Visual Studio 2026.
2. Build the solution.
   - If automatic NuGet restore is disabled, right-click the solution →
     **Restore NuGet Packages** before building.
3. Run the tests:
   - Open **Test Explorer** (Test → Test Explorer) — xUnit tests are picked
     up automatically, or
   - Run `dotnet test` from the solution root.
