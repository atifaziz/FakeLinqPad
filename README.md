# FakeLinqPad

[![NuGet][nuget-badge]][nuget-pkg]


FakeLinqPad is a library mostly designed to be used with [LINQPad][linqpad]
queries compiled using [LinqPadless][lpless]. It fakes some of the [LINQPad
API][linqpad-api] so that it can be used as a stand-in replacement and LINQPad
queries do not have to be re-written when executed without LINQPad.

It is not a goal to provide 100% coverage of the LINQPad API but some
reasonable implementation that works well outside of LINQPad. For example,
the default implementation of the `Dump` method simply writes to
[`Console.Error`][stderr].


## Contributing

If you want to help expand the LINQPad API coverage, [create an
issue][newissue] explaining your proposal for review (preferred) or [submit a
pull request][newpr] if you think you have it right the first time but can bare
the risk of being rejected if you need to start over.


[lpless]: https://github.com/linqpadless/LinqPadless
[linqpad]: http://www.linqpad.net/
[linqpad-api]: https://www.nuget.org/packages/LINQPad
[stderr]: https://msdn.microsoft.com/en-us/library/system.console.error
[newissue]: https://github.com/linqpadless/FakeLinqPad/issues/new
[newpr]: https://github.com/linqpadless/FakeLinqPad/compare
[nuget-badge]: https://img.shields.io/nuget/v/FakeLinqPad.svg
[nuget-pkg]: https://www.nuget.org/packages/FakeLinqPad
