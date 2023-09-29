namespace TestProject1.Tests
{
    /*public class UnitTest1
    {
        [Fact] //creates unique test cases, fact is a decorator
        
        public void Test1()
        {

        }
    }*/
    /*
    public class FactTest
    {
        [Fact]
        public void MustBeEqual()
        {
            var expVal = 2;
            var actVal = 2;
            Assert.Equal(expVal, actVal);
        }

      
    }

    public class AsyncFactTest
    {
        [Fact]
        public async Task MustBeEqual()
        {
            var expVal = 2;
            var actVal = 2;
            await Task.Yield();
            Assert.Equal(expVal, actVal);
        }
    }

    public class AssertionTest
    {
        [Fact]
        public void CheckingXUnitAsserts()
        {
            object o1 = new EarlClass
            {
                Name = "object1"
            };

            object o2 = new EarlClass
            {
                Name = "object1"
            };

            object o3 = o1;

            object? o4 = default(EarlClass);


            Assert.Equal(expected: 2, actual: 2);
            Assert.NotEqual(expected: 2, actual: 1);
            Assert.Same(o1, o3);
            Assert.NotSame(o2, o3);
            Assert.Equal(o1, o2);
            Assert.Null(o4);
            Assert.NotNull(o3);

            var instOfEarlClass = Assert.IsType<EarlClass>(o1);
            Assert.Equal(expected: "object1", actual: instOfEarlClass.Name);

            var exception = Assert.Throws<SomeException>(testCode: () => OpThatThrows("Jay"));
            Assert.Equal(expected: "Jay", actual: exception.Name);

            static void OpThatThrows(string name)
            {
                throw new SomeException
                {
                    Name = name
                };
            }
        }


        private record class EarlClass
        {
            public string? Name { get; set; }
        };

        private class SomeException : Exception
        {
            public string? Name { get; set; }
        };

    }
    */

    public class InlineDataTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(5, 5)]

        public void MustBeEqual2(int v1, int v2)
        {
            Assert.Equal(v1, v2);
        }
    };


    public class MemberDataTest
    {
        public static IEnumerable<object[]> Data => new[]
        {
            new object[] { 1, 2, false },
            new object[] { 2, 2, true },
            new object[] { 3, 3, true },
        };

        public static TheoryData<int, int, bool> TypeData => new TheoryData<int, int, bool>
        {
            { 3, 2, false },
            { 2, 3, false },
            { 5, 5, true },
        };

        [Theory]
        [MemberData(nameof(Data))]
        [MemberData(nameof(TypeData))]
        [MemberData(nameof(ExternalData.GetData),10,MemberType =typeof(ExternalData))]
        [MemberData(nameof(ExternalData.TypeData),MemberType = typeof(ExternalData))]

        public void MustBeEqual(int v1, int v2, bool mbe)
        {
            if (mbe)
            {
                Assert.Equal(v1, v2);
            }else { Assert.NotEqual(v1, v2); }
        }

        public class ExternalData
        {
            public static IEnumerable<object[]> GetData(int start) => new[]
        {
            new object[] { start, start, true },
            new object[] { start, start + 1, false },
            new object[] { start +1, start + 1, true },
        };

            public static TheoryData<int, int, bool> TypeData => new TheoryData<int, int, bool>
        {
            { 20, 30, false },
            { 40, 50, false },
            { 50, 50, true },
        };

        }

    }

    public class ClassDataTest
    {
        [Theory]
        [ClassData(typeof(TheoryDataClass))]
        [ClassData(typeof(TheoryTypeDataClass))]

        public void MustBeEqual(int v1, int v2, bool mbe)
        {
            if (mbe)
            {
                Assert.Equal(v1, v2);
            }
            else { Assert.NotEqual(v1, v2); }
        }

        public class TheoryDataClass : IEnumerable<object[]> 
        {
            //
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { 1, 2, false };
                yield return new object[] { 2, 2, true };
                yield return new object[] { 3, 3, true };
            }
            IEnumerator IEnumerable.GetEnumerator() { return (IEnumerator) GetEnumerator(); }




        }

        public class TheoryTypeDataClass : TheoryData<int,int,bool>
        {
            public TheoryTypeDataClass()
            {
                Add(102, 104, false);

            }
        }

    };

    [Fact]
    public void MustBeEqual()
    {
        //Arrange
        var a = 1;
        var b = 2;
        var xRes = 3;

        //Act

        var res = a + b;

        //Assert

        Assert.Equal(xRes, res);

    }
}

