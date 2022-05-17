 Feature: Banking Application 

  Banking application as per the stakeholders specs

  @mytag
  Scenario: Staff Fees
    Given I have a <Account>
    And when it is of <Staff Type> 
    When I acrue <Fees>
    Then the result should be <50%> of the <Total>

  Examples:
  | Account | Staff Type | Fees | Total |
  | Yes     | Yes        | 100  | 50    |
  | Yes     | No         | 100  | 100   |
  | Yes     | Yes        | 50   | 25    |

  @mytag
  Scenario: Everyday Account Transfers money to Invest
    Given I have an <Account>
    And it is <Type> Everyday
    And I am moving it to <Type> Invest
    When I move <Money> between accounts
    Then the <Money> is moved

  @mytag
  Scenario: Everyday Account Transfers money to Omni
    Given I have an <Account>
    And it is <Type> Everyday
    And I am moving it to <Type> Omni
    When I move <Money> between accounts
    Then the <Money> is moved

@mytag
  Scenario: Everyday Account Transfers money to Everyday
    Given I have an <Account>
    And it is <Type> Everyday
    And I am moving it to <Type> Everyday
    When I move <Money> between accounts
    Then the <Money> is moved

@mytag
  Scenario: Money Transfered From Invest to Everyday
    Given I have <Transfered Money>
    And It is account <Type> Invest
    And I am moving it to <Type> Everyday
    When I move <Money> between accounts
    Then the <Money> is moved

@mytag
  Scenario: Money Transfered From Invest to Invest
    Given I have <Transfered Money>
  And It is account <Type> Invest
  And I am moving it to <Type> Invest
  When I move <Money> between accounts
  Then the <Money> is moved

@mytag
  Scenario: Money Transfered From Invest to Omni
    Given I have <Transfered Money>
    And It is account <Type> Invest
    And I am moving it to <Type> Omni
    When I move <Money> between accounts
    Then the <Money> is moved

@mytag
   Scenario: Money Transfered From Omni to Everyday
    Given I have <Transfered Money>
    And It is account <Type> Omni
    And I am moving it to <Type> Everyday
    When I move <Money> between accounts
    Then the <Money> is moved

@mytag
   Scenario: Money Transfered From Omni to Invest
    Given I have <Transfered Money>
    And It is account <Type> Omni
    And I am moving it to <Type> Invest
    When I move <Money> between accounts
    Then the <Money> is moved

@mytag
   Scenario: Money Transfered From Omni to Omni
    Given I have <Transfered Money>
    And It is account <Type> Omni
    And I am moving it to <Type> Omni
    When I move <Money> between accounts
    Then the <Money> is moved

@mytag
  Scenario: Everyday Account Intrest
    Given I have an <Account>
    And it is <Type> Everyday
    And my <Balance> is positive
    When I acrue <Intrest>
    Then the result is no <Change>

@mytag
  Scenario:Invest Account Intrest
    Given I have an <Account>
    And it is <Type> invest
    And my <Balance> is positive
    When I acrue <Intrest>
    Then the result is +4% <Change>

@mytag
  Scenario: Omni Account Intrest on balance 1000$
    Given I have an <Account>
    And it is <Type> omni
    And my <Balance> is over 1000
    When I acrue <Intrest>
    Then the result is a +4% <Change>

@mytag
  Scenario: Omni account intrest on balance less than 1000$
    Given I have an <Account>
    And it is <Type> omni
    And my <Balance> is less than 1000
    When I acrue <Intrest>
    Then the result is no <Change>

@mytag
  Scenario: Everyday account overdraft
    Given I have an <Account>
    And it is <Type> Everyday
    And it has a <Balance> of 100
    When I try and <Withdraw> 101
    Then it is a <Failed Transaction>

@mytag
  Scenario: Invest account overdraft
    Given I have an <Account>
    And it is <Type> Omni
    And it has a <Balance> of 50
    When I try and <Withdraw> 55
    Then the result is a <Failed Transaction>

@mytag
  Scenario: Omni account overdraft by set amount (accepted)
    Given I have an <Account>
    And it is <Type> Omni
    And it has a <Balance> of 50
    And it has an <Overdraft Limit> of 50
    When I try to <Withdraw> 100
    Then the result its a <Balance> of -50

@mytag
  Scenario: Omni account overdraft by set amount (Failed)
    Given I have an <Account>
    And it is <Type> Omni
    And it has a <Balance> of 50
    And it has an <Overdraft Limit> of 10
    When I try to <Withdraw> 100
    Then the result its a <Deducted Transaction>

@mytag
  Scenario: Failed transaction with fee (Deducted Transaction - Omni)
    Given I have an <Account>
    And it is <Type> Omni
    And I try and make a <Withdrawl>
    And the withdrawl <Fails>
    When the <Balance> resets
    Then I am <Deducted> 10.00

@mytag
  Scenario: Failed transaction with no fee 
    Given I have an <Account>
    And I try and make a <Withdrawl>
    And the withdrawl <Fails>
    When the <Balance> resets
    Then I am <Deducted> 0
  
@mytag
  Scenario: Failed transaction with fee (Deducted Transaction - Invest)
    Given I have an <Account>
    And it is <Type> Invest
    And I try and make a <Withdrawl>
    And the withdrawl <Fails>
    When the <Balance> resets
    Then I am <Deducted> 10.00
