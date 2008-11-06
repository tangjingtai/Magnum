namespace Magnum.ProtocolBuffers.Specs
{
    using System;
    using System.Linq.Expressions;
    using NUnit.Framework;

    [TestFixture]
    public class Message_fields_have_assigned_number_tags :
        Specification
    {
        [Test]
        public void Mappings_need_number_tags()
        {
            Expression<Func<TestMessage, string>> function = m => m.Name;

            var fieldMapping = new FieldMapping<TestMessage, string>(function, 1);

            Assert.AreEqual(1, fieldMapping.NumberTag);
        }
    }
}