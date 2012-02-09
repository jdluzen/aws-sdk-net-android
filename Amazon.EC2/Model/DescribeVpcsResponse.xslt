<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:ec2="http://ec2.amazonaws.com/doc/2011-12-15/" exclude-result-prefixes="ec2">
    <xsl:output method="xml" omit-xml-declaration="no" indent="yes"/>
    <xsl:variable name="ns" select="'http://ec2.amazonaws.com/doc/2011-12-15/'"/>
    <xsl:template match="ec2:DescribeVpcsResponse">
        <xsl:element name="DescribeVpcsResponse" namespace="{$ns}">
            <xsl:element name="ResponseMetadata" namespace="{$ns}">
                <xsl:element name="RequestId" namespace="{$ns}">
                    <xsl:value-of select="ec2:requestId"/>
                </xsl:element>
            </xsl:element>
            <xsl:element name="DescribeVpcsResult" namespace="{$ns}">
                <xsl:apply-templates select="ec2:vpcSet"/>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:vpcSet">
        <xsl:apply-templates select="ec2:item"/>
    </xsl:template>
    <xsl:template match="ec2:item">
        <xsl:element name="Vpc" namespace="{$ns}">
            <xsl:element name="VpcId" namespace="{$ns}">
                <xsl:value-of select="ec2:vpcId"/>
            </xsl:element>
            <xsl:element name="VpcState" namespace="{$ns}">
                <xsl:value-of select="ec2:state"/>
            </xsl:element>
            <xsl:element name="CidrBlock" namespace="{$ns}">
                <xsl:value-of select="ec2:cidrBlock"/>
            </xsl:element>
            <xsl:element name="DhcpOptionsId" namespace="{$ns}">
                <xsl:value-of select="ec2:dhcpOptionsId"/>
            </xsl:element>
            <xsl:element name="InstanceTenancy" namespace="{$ns}">
              <xsl:value-of select="ec2:instanceTenancy"/>
            </xsl:element>
            <xsl:apply-templates select="ec2:tagSet" />
        </xsl:element>
    </xsl:template>
    <xsl:template match="ec2:tagSet">
      <xsl:for-each select="ec2:item">
        <xsl:element name="Tag" namespace="{$ns}">
          <xsl:element name="Key" namespace="{$ns}">
            <xsl:value-of select="ec2:key" />
          </xsl:element>
          <xsl:element name="Value" namespace="{$ns}">
            <xsl:value-of select="ec2:value" />
          </xsl:element>
        </xsl:element>
      </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
