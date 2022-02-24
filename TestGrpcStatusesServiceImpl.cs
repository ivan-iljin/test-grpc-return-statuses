using error.tests.grpc;
using Grpc.Core;

namespace TestGrpcStatuses
{
    public class TestGrpcStatusesServiceImpl : TestGrpcStatusService.TestGrpcStatusServiceBase
    {
        public override Task<emptyResponse> testStatusOK(emptyRequest request, ServerCallContext context)
        {
            return Task.FromResult(new emptyResponse());
        }

        public override Task<emptyResponse> testStatusCancelled(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Cancelled, "test status details"));
        }
        public override Task<emptyResponse> testStatusUnknown(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unknown, "test status details"));
        }
        public override Task<emptyResponse> testStatusInvalidArgument(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.InvalidArgument, "test status details"));
        }
        public override Task<emptyResponse> testStatusDeadlineExceeded(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.DeadlineExceeded, "test status details"));
        }
        public override Task<emptyResponse> testStatusNotFound(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.NotFound, "test status details"));
        }
        public override Task<emptyResponse> testStatusAlreadyExists(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.AlreadyExists, "test status details"));
        }
        public override Task<emptyResponse> testStatusPermissionDenied(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.PermissionDenied, "test status details"));
        }
        public override Task<emptyResponse> testStatusUnauthenticated(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unauthenticated, "test status details"));
        }
        public override Task<emptyResponse> testStatusResourceExhausted(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.ResourceExhausted, "test status details"));
        }
        public override Task<emptyResponse> testStatusFailedPrecondition(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.FailedPrecondition, "test status details"));
        }
        public override Task<emptyResponse> testStatusAborted(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Aborted, "test status details"));
        }
        public override Task<emptyResponse> testStatusOutOfRange(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.OutOfRange, "test status details"));
        }
        public override Task<emptyResponse> testStatusUnimplemented(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unimplemented, "test status details"));
        }
        public override Task<emptyResponse> testStatusInternal(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Internal, "test status details"));
        }
        public override Task<emptyResponse> testStatusUnavailable(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unavailable, "test status details"));
        }
        public override Task<emptyResponse> testStatusDataLoss(emptyRequest request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.DataLoss, "test status details"));
        }
    }
}
