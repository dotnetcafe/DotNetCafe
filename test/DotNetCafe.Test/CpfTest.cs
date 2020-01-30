using System;
using DotNetCafe.Globalization;
using Xunit;

namespace DotNetCafe.Test
{
    public class CpfTest
    {
        #region Constants

        const long A_NUMBER = 100_100_100_00L;
        const long B_NUMBER = 200_200_200_00L;
        const long C_NUMBER = 300_300_300_00L;

        #endregion

        #region IsEmpty

        [Fact]
        public void TestIsEmpty()
        {
            Assert.Equal(Cpf.Empty, new Cpf());
        }

        #endregion

        #region Constructor

        [Fact(Skip = "Not Implemented")]
        public void TestConstructor()
        {
            throw new NotImplementedException();
        }

        [Fact(Skip = "Not Implemented")]
        public void TestConstructorThrowsException()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Parse & TryParse

        [Fact(Skip = "Not Implemented")]
        public void TestParse()
        {
            throw new NotImplementedException();
        }

        [Fact(Skip = "Not Implemented")]
        public void TestParseThrowsException()
        {
            throw new NotImplementedException();
        }

        [Fact(Skip = "Not Implemented")]
        public void TestTryParse()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ToString

        [Fact]
        public void TestToString()
        {
            var a = new Cpf(A_NUMBER);
            string expected = "100.100.100-00";

            Assert.Equal(expected, a.ToString());
        }

        [Fact]
        public void TestToStringBarFormat()
        {
            var a = new Cpf(B_NUMBER);
            string expected = "200200200/00";

            Assert.Equal(expected, a.ToString("B"));
        }

        [Fact]
        public void TestToStringNumericFormat()
        {
            var a = new Cpf(C_NUMBER);
            string expected = "30030030000";

            Assert.Equal(expected, a.ToString("N"));
        }

        [Fact]
        public void TestToStringThrowsException()
        {
            var exception = Assert.Throws<FormatException>(() => new Cpf(A_NUMBER).ToString("?"));
            string expected = string.Format(SR.FormatException_InvalidFormat, "?");

            Assert.Equal(expected, exception.Message);
        }

        #endregion

        #region Comparison
            
        [Fact]
        public void TestCompareToNull()
        {
            var a = new Cpf(A_NUMBER);

            Assert.True(a.CompareTo(null!) > 0);
        }

        [Fact]
        public void TestCompareToObject()
        {
            var a = new Cpf(A_NUMBER);

            Assert.True(a.CompareTo(new object()) > 0);
        }

        #endregion

        #region Equality

        [Fact]
        public void TestEquals()
        {
            var a = new Cpf(A_NUMBER);
            var b = new Cpf(A_NUMBER);

            Assert.True(a.Equals(b));
        }

        [Fact]
        public void TestGetHashCode()
        {
            var a = new Cpf(A_NUMBER);
            var b = new Cpf(A_NUMBER);

            Assert.Equal(a.GetHashCode(), b.GetHashCode());
        }

        #endregion

        #region Comparison Operators

        [Fact]
        public void TestOpGreaterThan()
        {
            var a = new Cpf(C_NUMBER);
            var b = new Cpf(B_NUMBER);

            Assert.True(a > b);
        }

        [Fact]
        public void TestOpLesserThan()
        {
            var a = new Cpf(A_NUMBER);
            var b = new Cpf(B_NUMBER);

            Assert.True(a < b);
        }

        [Fact]
        public void TestOpGreaterOrEqualTo()
        {
            var a = new Cpf(C_NUMBER);
            var b = new Cpf(C_NUMBER);
            var c = new Cpf(B_NUMBER);

            Assert.True(a >= b && a >= c);
        }

        [Fact]
        public void TestOpLesserOrEqualTo()
        {
            var a = new Cpf(A_NUMBER);
            var b = new Cpf(A_NUMBER);
            var c = new Cpf(B_NUMBER);

            Assert.True(a <= b && a <= c);
        }

        #endregion

        #region Equality Operators
        
        [Fact]
        public void TestOpEqualTo()
        {
            var a = new Cpf(A_NUMBER);
            var b = new Cpf(A_NUMBER);

            Assert.True(a == b);
        }

        [Fact]
        public void TestOpNotEqualTo()
        {
            var a = new Cpf(A_NUMBER);
            var b = new Cpf(B_NUMBER);

            Assert.True(a != b);
        }

        #endregion
    }
}
