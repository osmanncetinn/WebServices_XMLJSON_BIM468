<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/api/distribution.proto

namespace Google\Api;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A set of buckets with arbitrary widths.
 * Defines `size(bounds) + 1` (= N) buckets with these boundaries for
 * bucket i:
 *    Upper bound (0 <= i < N-1):     bounds[i]
 *    Lower bound (1 <= i < N);       bounds[i - 1]
 * There must be at least one element in `bounds`.  If `bounds` has only one
 * element, there are no finite buckets, and that single element is the
 * common boundary of the overflow and underflow buckets.
 *
 * Generated from protobuf message <code>google.api.Distribution.BucketOptions.Explicit</code>
 */
class Distribution_BucketOptions_Explicit extends \Google\Protobuf\Internal\Message
{
    /**
     * The values must be monotonically increasing.
     *
     * Generated from protobuf field <code>repeated double bounds = 1;</code>
     */
    private $bounds;

    public function __construct() {
        \GPBMetadata\Google\Api\Distribution::initOnce();
        parent::__construct();
    }

    /**
     * The values must be monotonically increasing.
     *
     * Generated from protobuf field <code>repeated double bounds = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getBounds()
    {
        return $this->bounds;
    }

    /**
     * The values must be monotonically increasing.
     *
     * Generated from protobuf field <code>repeated double bounds = 1;</code>
     * @param float[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setBounds($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::DOUBLE);
        $this->bounds = $arr;

        return $this;
    }

}

