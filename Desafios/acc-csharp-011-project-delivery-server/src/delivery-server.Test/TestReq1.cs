using Xunit;
using FluentAssertions;
using delivery_server;
using System;

namespace delivery_server.Test;

public class TestReq1
{
    [Theory(DisplayName = "Deve construir um Item corretamente")]
    [InlineData()]

    public void TestCreateItem(string nameEntry, double priceEntry, int timeEntry)
    {
        throw new NotImplementedException();
    }
}