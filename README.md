# FakeLinqPad

FakeLinqPad is a library mostly designed to be used with [LINQPad][linqpad]
queries compiled using [LinqPadless][lpless]. It fakes some of the [LINQPad
API][linqpad-api] so that it can be used as a stand-in replacement and LINQPad
queries do not have to be re-written when executed without LINQPad.

It is not a goal to provide 100% coverage of the LINQPad API but some
reasonable implementation.


[lpless]: https://github.com/linqpadless/LinqPadless
[linqpad]: http://www.linqpad.net/
[linqpad-api]: https://www.nuget.org/packages/LINQPad
