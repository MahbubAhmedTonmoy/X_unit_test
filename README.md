# X_unit_test


[Fact] – attribute states that the method should be executed by the test runner


[Theory] – attribute implies that we are going to send some parameters to our testing code. So, it is similar to the [Fact] attribute, because it states that the method should be executed by the test runner, but additionally implies that we are going to send parameters to the test method



[InlineData] – attribute provides those parameters we are sending to the test method. If we are using the [Theory] attribute, we have to use the [InlineData] as well



        --------------------------------code-----------------------------
        [Fact]
        public void IsValid_ValidAccountNumber_ReturnsTrue()
        {
            Assert.True(_validation.IsValid("123-4543234576-23"));
        }

        [Theory]
        [InlineData("1234-3454565676-23")]
        [InlineData("12-3454565676-23")]
        public void IsValid_AccountNumberFirstPartWrong_ReturnsFalse(string accountNumber)
        {
            Assert.False(_validation.IsValid(accountNumber));
        }
