# 321SolidPrinciples

ConnectFourPoor.cs
--------------------
# The board class has more than one reason to change, as it needs to be modified whenever a new rule or feature is added or an exisiting one is changed. This violates the SRP and makes the class hard to maintain and test. 

# The board class is not open for extension, as it does not allow adding new rules or features without modifying the existing code. This violates the OCP and makes the class rigid and fragile. 
