#include <stdint.h>

typedef struct QUIC_GLOBAL_SETTINGS {
    union {
        uint64_t IsSetFlags;
        struct {
            uint64_t RetryMemoryLimit                       : 1;
            uint64_t LoadBalancingMode                      : 1;
            uint64_t FixedServerID                          : 1;
            uint64_t RESERVED                               : 61;
        } IsSet;
    };
    uint16_t RetryMemoryLimit;
    uint16_t LoadBalancingMode;
    uint32_t FixedServerID;
} QUIC_GLOBAL_SETTINGS;
